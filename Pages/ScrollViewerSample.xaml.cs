﻿//------------------------------------------------------------------------------
// <copyright file="ScrollViewerSample.xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.ControlsBasics
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Interaction logic for ScrollViewerSample
    /// </summary>
    public partial class ScrollViewerSample : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollViewerSample"/> class.
        /// </summary>
        public ScrollViewerSample(string ImageSource)
        {
            this.InitializeComponent();

            BitmapImage bi3 = new BitmapImage(new Uri(ImageSource, UriKind.Relative));

            ImageField.Source = bi3;
        }
    }
}