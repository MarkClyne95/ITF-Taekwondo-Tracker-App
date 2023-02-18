using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TKD_Companion_App.Models;
using Xamarin.Forms;

namespace TKD_Companion_App.Services
{
    public class MockDataStore : IDataStore<Student>
    {
        readonly List<Student> items;

        public MockDataStore()
        {
            items = new List<Student>()
            {
                new Student { Id = Guid.NewGuid().ToString(), Text = "Mark Clyne", Grade="Green Tag" },
            };
        }

        public async Task<bool> AddItemAsync(Student item)
        {
            items.Add(item);

            Application.Current.Properties["id"] = item.Id;
            Application.Current.Properties["Name"] = item.Text;
            Application.Current.Properties["Grade"] = item.Grade;

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Student item)
        {
            var oldItem = items.Where((Student arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            Application.Current.Properties["id"] = item.Id;
            Application.Current.Properties["Name"] = item.Text;
            Application.Current.Properties["Grade"] = item.Grade;

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Student arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Student> GetItemAsync(string id)
        {
            var student = new Student();
            student.Id = Application.Current.Properties["id"] as string;
            student.Text = Application.Current.Properties["Name"] as string;
            student.Grade = Application.Current.Properties["Grade"] as string;
            return student;
        }

        public async Task<IEnumerable<Student>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}