#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Utility;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace SfDataGridDemo
{
    public static class ContextMenuCommands
    {
        private static BaseCommand addSort;

        public static BaseCommand AddSort
        {
            get
            {
                if (addSort == null)
                    addSort = new BaseCommand(OnAddSortClicked);
                return addSort;
            }
        }

        private static BaseCommand addGroup;

        public static BaseCommand AddGroup
        {
            get
            {
                if (addGroup == null)
                    addGroup = new BaseCommand(OnAddGroupClicked);
                return addGroup;
            }
        }

        private static BaseCommand clearSort;

        public static BaseCommand ClearSort
        {
            get
            {
                if (clearSort == null)
                    clearSort = new BaseCommand(OnClearSortClicked);
                return clearSort;
            }
        }

        private static BaseCommand clearGroup;

        public static BaseCommand ClearGroup
        {
            get
            {
                if (clearGroup == null)
                    clearGroup = new BaseCommand(OnClearGroupClicked);
                return clearGroup;
            }
        }

        private static BaseCommand copy;
        public static BaseCommand Copy
        {
            get
            {
                if (copy == null)
                    copy = new BaseCommand(OnCopyClicked);
                return copy;
            }
        }

        private static BaseCommand paste;
        public static BaseCommand Paste
        {
            get
            {
                if (paste == null)
                    paste = new BaseCommand(OnPasteClicked);
                return paste;
            }
        }

        private static void OnAddSortClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            var column = paramList[1] as GridColumn;
            dataGrid.SortColumnDescriptions.Add(new SortColumnDescription() { ColumnName = column.MappingName });
        }

        private static void OnAddGroupClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            var column = paramList[1] as GridColumn;
            dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription() { ColumnName = column.MappingName });
        }
        private static void OnClearSortClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            var column = paramList[1] as GridColumn;
            dataGrid.SortColumnDescriptions.Clear();
        }
        private static void OnClearGroupClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            var column = paramList[1] as GridColumn;
            dataGrid.GroupColumnDescriptions.Clear();
        }

        private static void OnCopyClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            dataGrid.GridCopyPaste.Copy();
        }
        
        private static void OnPasteClicked(object obj)
        {
            var paramList = (List<object>)obj;
            var dataGrid = paramList[0] as SfDataGrid;
            dataGrid.GridCopyPaste.Paste();
        }
    }
}
