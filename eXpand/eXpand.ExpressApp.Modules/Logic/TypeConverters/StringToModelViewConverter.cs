﻿using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.ExpressApp.Model;

namespace eXpand.ExpressApp.Logic.TypeConverters {
    public class StringToModelViewConverter : TypeConverter
    {
        readonly IModelApplication _modelApplication;

        public StringToModelViewConverter(IModelApplication modelApplication)
        {
            _modelApplication = modelApplication;
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            return _modelApplication.Views.Where(view => view.Id == value.ToString()).Single();
        }
    }
}