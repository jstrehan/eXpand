﻿using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using eXpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using eXpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.AdditionalViewControls.ConditionalViewControlsPositioning
{
    public class AttributeRegistrator:Module.AttributeRegistrator
    {
        public override IEnumerable<Attribute> GetAttributes(ITypeInfo typesInfo) {
            if (typesInfo.Type!=typeof(Customer))yield break;
            yield return new AdditionalViewControlsRuleAttribute(Captions.ViewMessage + " " + Captions.HeaderConditionalViewControlsPositioning, "1=1",
                "1=1", Captions.ViewMessageConditionalViewControlsPositioning, Position.Bottom){View = "ConditionalViewControlsPositioning_DetailView"};
            yield return new AdditionalViewControlsRuleAttribute(Captions.Header + " " + Captions.HeaderConditionalViewControlsPositioning, "1=1", "1=1",
                Captions.HeaderConditionalViewControlsPositioning, Position.Top)
            {View = "ConditionalViewControlsPositioning_DetailView"};
            yield return new AdditionalViewControlsRuleAttribute(Captions.ConditionalViewControlsPositioningForCustomerName, "1=1", "1=1", null, Position.DetailViewItem)
            {MessageProperty = "NameWarning", View = "ConditionalViewControlsPositioning_DetailView"};
            yield return new AdditionalViewControlsRuleAttribute(Captions.ConditionalViewControlsPositioningForCustomerCity, "1=1", "1=1", null, Position.DetailViewItem)
            {MessageProperty = "CityWarning", View = "ConditionalViewControlsPositioning_DetailView"};
            yield return new CloneViewAttribute(CloneViewType.DetailView, "ConditionalViewControlsPositioning_DetailView");
            yield return new NavigationItemAttribute("Additional View Controls/Conditional View Controls Positioning",
                "ConditionalViewControlsPositioning_DetailView");
            yield return new DisplayFeatureModelAttribute("ConditionalViewControlsPositioning_DetailView");
        }
    }
}