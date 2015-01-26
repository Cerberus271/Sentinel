﻿#region License
//
// © Copyright Ray Hayes
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
//
#endregion

#region Using directives

using System.Windows.Controls;
using Sentinel.Filters.Interfaces;
using Sentinel.Services;

#endregion

namespace Sentinel.Filters.Gui
{
    /// <summary>
    /// Interaction logic for FiltersControl.xaml
    /// </summary>
    public partial class FiltersControl : UserControl
    {
        public FiltersControl()
        {
            InitializeComponent();

            var service = ServiceLocator.Instance.Get<IFilteringService<IFilter>>();
            if (service != null)
            {
                Filters = service;
            }

            DataContext = this;
        }

        public IFilteringService<IFilter> Filters { get; private set; }
    }
}