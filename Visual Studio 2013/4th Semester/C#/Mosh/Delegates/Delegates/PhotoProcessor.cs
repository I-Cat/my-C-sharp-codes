using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class PhotoProcessor
    {
       // public delegate void photoFilterHander(Photo photo);
        public void Process (String path,Action<Photo> PhotoHandler)
        {

            var photo = Photo.Load(path);
            PhotoHandler(photo);
        }
    }
}
