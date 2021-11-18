using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard_Client {
    class State {
        List<string> soundboardQueue;
        int volume;
        List<string> musicQueue;
        string playingTrack;

        public State(List<string> soundboardQueue, int volume, List<string> musicQueue, string playingTrack) {
            this.soundboardQueue = soundboardQueue;
            this.volume = volume;
            this.musicQueue = musicQueue;
            this.playingTrack = playingTrack;
        }

        public List<string> getSoundboardQueue() {
            return this.soundboardQueue;
        }

        public int getVolume() {
            return this.volume;
        }

        public List<string> getMusicQueue() {
            return this.musicQueue;
        }

        public string getPlayingTrack() {
            return playingTrack;
        }
    }
}
