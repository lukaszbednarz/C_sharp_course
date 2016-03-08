using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningLine.Practice
{
    class BackgroundMusicWrapper : IDisposable

    {
        private bool Disposed = false;

        public BackgroundMusicWrapper()
        { 
        }

        public void Play()
        {
            if (Disposed)
            {
                throw new ObjectDisposedException("The music player has been disposed");
            }
            BackgroundMusicLib.Play();
        }

        public void Pause()
        {
            if (Disposed)
            {
                throw new ObjectDisposedException("The music player has been disposed");
            } 
            BackgroundMusicLib.Pause();
        }

        public void Stop()
        {
            if (Disposed)
            {
                throw new ObjectDisposedException("The music player has been disposed");
            }
            BackgroundMusicLib.Stop();
        }

        public void Shutdown()
        {
            BackgroundMusicLib.Shutdown();
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (!Disposed)
            {
                if (isDisposing)
                {
                    Shutdown();
                }

                Disposed = true;
            }
            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~BackgroundMusicWrapper()
        {
            Shutdown();
        }


        
    }
}
