using LCScheduler.Model;

namespace LCScheduler.Reports
{
    public partial class ProgressNoteReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ProgressNoteReport()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ProgressNoteInformation.AppearanceOptions appearanceIndex = (ProgressNoteInformation.AppearanceOptions) GetCurrentColumnValue("Appearance");

            switch (appearanceIndex)
            {
                case ProgressNoteInformation.AppearanceOptions.WNL:
                {
                    xrCheckBox_A_WNL.Checked = true;
                    break;
                }
                case ProgressNoteInformation.AppearanceOptions.Unkempt:
                {
                    xrCheckBox_A_Unkempt.Checked = true;
                    break;
                }
                case ProgressNoteInformation.AppearanceOptions.Dirty:
                {
                    xrCheckBox_A_Dirty.Checked = true;
                    break;
                }
                case ProgressNoteInformation.AppearanceOptions.Meticulous:
                {
                    xrCheckBox_A_Meticulous.Checked = true;
                    break;
                }
                case ProgressNoteInformation.AppearanceOptions.Unusual:
                {
                    xrCheckBox_A_Unusual.Checked = true;
                    break;
                }
            }

            ProgressNoteInformation.BehaviorOptions behaviorIndex = (ProgressNoteInformation.BehaviorOptions) GetCurrentColumnValue("Behavior");

            switch (behaviorIndex)
            {
                case ProgressNoteInformation.BehaviorOptions.WNL:
                {
                    xrCheckBox_B_WNL.Checked = true;
                    break;
                }
                case ProgressNoteInformation.BehaviorOptions.Guarded:
                {
                    xrCheckBox_B_Guarded.Checked = true;
                    break;
                }
                case ProgressNoteInformation.BehaviorOptions.Withdrawn:
                {
                    xrCheckBox_B_Withdrawn.Checked = true;
                    break;
                }
                case ProgressNoteInformation.BehaviorOptions.Noncompliant:
                {
                    xrCheckBox_B_Noncompliant.Checked = true;
                    break;
                }
                case ProgressNoteInformation.BehaviorOptions.Hostile:
                {
                    xrCheckBox_B_Hostile.Checked = true;
                    break;
                }
            }

            ProgressNoteInformation.MoodAffectOptions moodAffectIndex = (ProgressNoteInformation.MoodAffectOptions) GetCurrentColumnValue("MoodAffect");

            switch (moodAffectIndex)
            {
                case ProgressNoteInformation.MoodAffectOptions.WNL:
                {
                    xrCheckBox_C_WNL.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Flat:
                {
                    xrCheckBox_C_Flat.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Depressed:
                {
                    xrCheckBox_C_Depressed.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Euphoric:
                {
                    xrCheckBox_C_Euphoric.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Anxious:
                {
                    xrCheckBox_C_Anxious.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Fearful:
                {
                    xrCheckBox_C_Fearful.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Irritable:
                {
                    xrCheckBox_C_Irritable.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Angry:
                {
                    xrCheckBox_C_Angry.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Labile:
                {
                    xrCheckBox_C_Labile.Checked = true;
                    break;
                }
                case ProgressNoteInformation.MoodAffectOptions.Incongruent:
                {
                    xrCheckBox_C_Incongruent.Checked = true;
                    break;
                }
            }

            ProgressNoteInformation.CognitionsOptions cognitionIndex = (ProgressNoteInformation.CognitionsOptions)GetCurrentColumnValue("Cognitions");

            switch (cognitionIndex)
            {
                case ProgressNoteInformation.CognitionsOptions.WNL:
                {
                    xrCheckBox_D_WNL.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Loose:
                {
                    xrCheckBox_D_Loose.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Scattered:
                {
                    xrCheckBox_D_Scattered.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Blocked:
                {
                    xrCheckBox_D_Blocked.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Illogical:
                {
                    xrCheckBox_D_Illogical.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Delusional:
                {
                    xrCheckBox_D_Delusional.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Paranoid:
                {
                    xrCheckBox_D_Paranoid.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Hallucinations:
                {
                    xrCheckBox_D_Hallucinations.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Grandiose:
                {
                    xrCheckBox_D_Grandiose.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Fragmented:
                {
                    xrCheckBox_D_Fragmented.Checked = true;
                    break;
                }
                case ProgressNoteInformation.CognitionsOptions.Somatic:
                {
                    xrCheckBox_D_Somatic.Checked = true;
                    break;
                }
            }
        }
    }
}
