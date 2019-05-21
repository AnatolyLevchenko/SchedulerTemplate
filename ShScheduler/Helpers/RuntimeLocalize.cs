using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ShScheduler.Helpers
{
    public static class RuntimeLocalize
    {
        public static void ChangeCulture(Form frm, CultureInfo cu)
        {
            CultureInfo culture = cu;

            Thread.CurrentThread.CurrentUICulture = culture;

            ComponentResourceManager resources = new ComponentResourceManager(frm.GetType());

            ApplyResourceToControl(resources, frm, culture);
            resources.ApplyResources(frm, "$this", culture);
        }

        private static void ApplyResourceToControl(ComponentResourceManager res, Control control, CultureInfo lang)
        {
            if (control.GetType() == typeof(MenuStrip))  // See if this is a menuStrip
            {
                MenuStrip strip = (MenuStrip)control;

                ApplyResourceToToolStripItemCollection(strip.Items, res, lang);
            }

            foreach (Control c in control.Controls) // Apply to all sub-controls
            {
                ApplyResourceToControl(res, c, lang);
                res.ApplyResources(c, c.Name, lang);
            }

            // Apply to self
            res.ApplyResources(control, control.Name, lang);
        }

        private static void ApplyResourceToToolStripItemCollection(ToolStripItemCollection col, ComponentResourceManager res, CultureInfo lang)
        {
            for (int i = 0; i < col.Count; i++)     // Apply to all sub items
            {
                ToolStripItem item = (ToolStripMenuItem)col[i];

                if (item.GetType() == typeof(ToolStripMenuItem))
                {
                    ToolStripMenuItem menuitem = (ToolStripMenuItem)item;
                    ApplyResourceToToolStripItemCollection(menuitem.DropDownItems, res, lang);
                }

                res.ApplyResources(item, item.Name, lang);
            }
        }
    }
}