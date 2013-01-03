using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DesignPattern
{
    class Document { public string content = string.Empty; }

    class OperationCommand
    {
        abstract class Command
        {
            protected Document _doc;
            public Command(Document doc)
            {
                this._doc = doc;
            }

            public abstract void Execute();
        }

        class WriteCommand : Command
        {
            public override void Execute()
            {
                _doc.content += "abc";
            }
        }

        class DeleteCommand : Command
        {

            public override void Execute()
            {
                _doc.content = string.Empty;
            }
        }
    }

    class ObjectCommand
    {
        abstract class Command
        {
            protected Document _doc;
            public Command(Document doc)
            {
                this._doc = doc;
            }

            public abstract void write();
            public abstract void delete();
        }

        class DocumentCommand : Command
        {
            public override void write()
            {
                _doc.content += "abc";
            }

            public override void delete()
            {
                _doc.content = string.Empty;
            }
        }
    }
}
