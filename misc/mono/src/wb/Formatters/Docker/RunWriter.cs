using System;
using System.Text;
using wb.Slices;

namespace wbd.Writers
{
    public class RunWriter
    {
        public void Write(SliceSection section, StringBuilder sb)
        {
            var text = string.Join($" && {"\\"} {Environment.NewLine}", section.Lines);
            sb.Append("RUN ");
            sb.AppendLine(text);
        } 
    }
}