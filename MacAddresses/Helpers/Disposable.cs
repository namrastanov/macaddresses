using System;

namespace MacAddresses.Helpers
{
    public class Disposable : IDisposable
    {
        private bool IsDisposed { get; set; }
        protected void Dispose(bool disposing)
        {
            if (disposing && !IsDisposed)
            {
                DisposeCore();
            }
            IsDisposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void DisposeCore()
        {}
        ~Disposable()
        {
            Dispose(false);
        }
    }
}