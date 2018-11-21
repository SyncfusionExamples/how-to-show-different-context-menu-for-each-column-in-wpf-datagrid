using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace SfDataGridDemo
{
    public class SfDataGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.GridContextMenuOpening += AssociatedObject_GridContextMenuOpening;
        }

        private void AssociatedObject_GridContextMenuOpening(object sender, GridContextMenuEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            var columnIndex = this.AssociatedObject.ResolveToGridVisibleColumnIndex(e.RowColumnIndex.ColumnIndex);
            if (columnIndex < 0 && columnIndex >= this.AssociatedObject.Columns.Count)
                return;
            var column = this.AssociatedObject.Columns[columnIndex];
            if (column == null)
                return;

            List<object> commandParameter = new List<object>();
            commandParameter.Add(this.AssociatedObject);
            commandParameter.Add(column);
            CommandBinding binding = new CommandBinding();
            this.AssociatedObject.CommandBindings.Add(binding);

            if (columnIndex < 3)
            {
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "AddSort",
                    Command = ContextMenuCommands.AddSort,
                    CommandParameter = commandParameter
                });
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "AddGroup",
                    Command = ContextMenuCommands.AddGroup,
                    CommandParameter = commandParameter
                });
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "ClearSort",
                    Command = ContextMenuCommands.ClearSort,
                    CommandParameter = commandParameter
                });
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "ClearGroup",
                    Command = ContextMenuCommands.ClearGroup,
                    CommandParameter = commandParameter
                });
            }
            else
            {
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "Copy",
                    Command = ContextMenuCommands.Copy,
                    CommandParameter = commandParameter
                });
                e.ContextMenu.Items.Add(new MenuItem()
                {
                    Header = "Paste",
                    Command = ContextMenuCommands.Paste,
                    CommandParameter = commandParameter
                });
            }
        }
    }
}
