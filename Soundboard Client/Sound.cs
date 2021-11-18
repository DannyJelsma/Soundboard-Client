using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard_Client {
    class Sound {
        string name;
        string file;

        public Sound(string name, string file) {
            this.name = name;
            this.file = file;
        }

        public string getName() {
            return name;
        }

        public string getFilePath() {
            return file;
        }
    }
}
