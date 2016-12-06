using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;
namespace LCScheduler.Forms
{
    public partial class CustomRecurrenceForm : AppointmentRecurrenceForm
    {
        public CustomRecurrenceForm()
        {
            InitializeComponent();
        }

        public CustomRecurrenceForm(Appointment pattern, FirstDayOfWeek firstDayOfWeek, AppointmentFormControllerBase controller, RecurrenceType recurrenceType) : base(pattern, firstDayOfWeek, controller)
        {
            chkWeekly.Checked = true;
            chkEndAfterNumberOfOccurrences.Checked = true;
        }
    }
}