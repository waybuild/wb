using System.Text;
using wb.Slices;

namespace wb.Formatters
{
    public interface IFormatter
    {
        void Write(Slice slice, StringBuilder sb);
        void Write(SliceSection section, StringBuilder sb);
    }
}