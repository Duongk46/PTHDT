using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc.Areas.Admin.DropdownList
{
    public class DropdownListItem
    {
        public IEnumerable<SelectListItem> DropdownListName(IEnumerable<EmployeeDTO> employeeDTO)
        {
            var listItem = new List<SelectListItem>();
            foreach(var item in employeeDTO)
            {
                listItem.Add(new SelectListItem() { Text = item.Name, Value = item.ID.ToString() });
            }
            return listItem;
        }
        public IEnumerable<SelectListItem> DropdownListTypeEmployee()
        {
            var listItem = new List<SelectListItem>();
            listItem.Add(new SelectListItem() { Text = "Chủ tịch", Value = "1" });
            listItem.Add(new SelectListItem() { Text = "Phó chủ tịch", Value = "2" });
            listItem.Add(new SelectListItem() { Text = "Giám đốc", Value = "3" });
            listItem.Add(new SelectListItem() { Text = "Nhân viên kĩ thuật", Value = "4" });
            listItem.Add(new SelectListItem() { Text = "Kế toán", Value = "5" });
            listItem.Add(new SelectListItem() { Text = "Ủy viên", Value = "6" });
            listItem.Add(new SelectListItem() { Text = "Thư kí", Value = "7" });
            return listItem;
        }
        public IEnumerable<SelectListItem> DropdownListTypeUser()
        {
            var listItem = new List<SelectListItem>();
            listItem.Add(new SelectListItem() { Text = "Quản lý", Value = "1" });
            listItem.Add(new SelectListItem() { Text = "Người dùng", Value = "2" });
            return listItem;
        }
        public IEnumerable<SelectListItem> DropdownListTypeSex()
        {
            var listItem = new List<SelectListItem>();
            listItem.Add(new SelectListItem() { Text = "Nam", Value = "true" });
            listItem.Add(new SelectListItem() { Text = "Nữ", Value = "false" });
            return listItem;
        }
    }
}
