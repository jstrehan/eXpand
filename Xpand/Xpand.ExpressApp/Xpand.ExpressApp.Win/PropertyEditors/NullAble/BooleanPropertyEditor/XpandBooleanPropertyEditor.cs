﻿using System;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors.Repository;
using Xpand.Utils.Helpers;

namespace Xpand.ExpressApp.Win.PropertyEditors.NullAble.BooleanPropertyEditor {
    [PropertyEditor(typeof(bool?),true)]
    [PropertyEditor(typeof(bool),true)]
    public class XpandBooleanPropertyEditor : DevExpress.ExpressApp.Win.Editors.BooleanPropertyEditor {
        public XpandBooleanPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }

        protected override void SetupRepositoryItem(RepositoryItem item) {
            base.SetupRepositoryItem(item);
            if (item is RepositoryItemBooleanEdit)
                ((RepositoryItemBooleanEdit)item).AllowGrayed = MemberInfo.MemberType.IsNullableType();
        }
    }
}