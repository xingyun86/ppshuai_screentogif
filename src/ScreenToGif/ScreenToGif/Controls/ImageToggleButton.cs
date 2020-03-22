﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ScreenToGif.Controls
{
    /// <summary>
    /// A toggle button with a image inside.
    /// </summary>
    public class ImageToggleButton : ToggleButton
    {
        #region Variables

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(ImageToggleButton), new FrameworkPropertyMetadata("Button"));

        public static readonly DependencyProperty KeyGestureProperty = DependencyProperty.Register(nameof(KeyGesture), typeof(string), typeof(ImageToggleButton), new FrameworkPropertyMetadata(""));

        public static readonly DependencyProperty ContentHeightProperty = DependencyProperty.Register(nameof(ContentHeight), typeof(double), typeof(ImageToggleButton), new FrameworkPropertyMetadata(double.NaN));

        public static readonly DependencyProperty ContentWidthProperty = DependencyProperty.Register(nameof(ContentWidth), typeof(double), typeof(ImageToggleButton), new FrameworkPropertyMetadata(double.NaN));

        /// <summary> 
        /// DependencyProperty for <see cref="TextWrapping" /> property.
        /// </summary>
        public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register(nameof(TextWrapping), typeof(TextWrapping), typeof(ImageToggleButton),
            new FrameworkPropertyMetadata(TextWrapping.NoWrap, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty DarkModeProperty = DependencyProperty.Register(nameof(DarkMode), typeof(bool), typeof(ImageToggleButton), new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty IsOverNonClientAreaProperty = DependencyProperty.Register(nameof(IsOverNonClientArea), typeof(bool), typeof(ImageToggleButton), new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty IsImportantProperty = DependencyProperty.Register(nameof(IsImportant), typeof(bool), typeof(ImageToggleButton), new FrameworkPropertyMetadata(false));

        #endregion

        #region Properties

        /// <summary>
        /// The text of the button.
        /// </summary>
        [Description("The text of the button."), Category("Common")]
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetCurrentValue(TextProperty, value);
        }

        /// <summary>
        /// The KeyGesture of the button.
        /// </summary>
        [Description("The KeyGesture of the button."), Category("Common")]
        public string KeyGesture
        {
            get => (string)GetValue(KeyGestureProperty);
            set => SetCurrentValue(KeyGestureProperty, value);
        }

        /// <summary>
        /// The height of the button content.
        /// </summary>
        [Description("The height of the button content."), Category("Common")]
        public double ContentHeight
        {
            get => (double)GetValue(ContentHeightProperty);
            set => SetCurrentValue(ContentHeightProperty, value);
        }

        /// <summary>
        /// The width of the button content.
        /// </summary>
        [Description("The width of the button content."), Category("Common")]
        public double ContentWidth
        {
            get => (double)GetValue(ContentWidthProperty);
            set => SetCurrentValue(ContentWidthProperty, value);
        }

        /// <summary>
        /// The TextWrapping property controls whether or not text wraps 
        /// when it reaches the flow edge of its containing block box. 
        /// </summary>
        public TextWrapping TextWrapping
        {
            get => (TextWrapping)GetValue(TextWrappingProperty);
            set => SetValue(TextWrappingProperty, value);
        }

        /// <summary>
        /// True if the button should ajust itself for dark mode.
        /// </summary>
        [Description("True if the button should ajust itself for dark mode.")]
        public bool DarkMode
        {
            get => (bool)GetValue(DarkModeProperty);
            set => SetCurrentValue(DarkModeProperty, value);
        }

        /// <summary>
        /// True if the button is being drawn on top of the non client area.
        /// </summary>
        [Description("True if the button is being drawn on top of the non client area.")]
        public bool IsOverNonClientArea
        {
            get => (bool)GetValue(IsOverNonClientAreaProperty);
            set => SetCurrentValue(IsOverNonClientAreaProperty, value);
        }

        /// <summary>
        /// True if the button should be diplayed with a warning color.
        /// </summary>
        [Description("True if the button should be diplayed with a warning color.")]
        public bool IsImportant
        {
            get => (bool)GetValue(IsImportantProperty);
            set => SetCurrentValue(IsImportantProperty, value);
        }

        #endregion

        static ImageToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageToggleButton), new FrameworkPropertyMetadata(typeof(ImageToggleButton)));
        }
    }
}