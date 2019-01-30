
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// 
    /// </summary>
   public class HomeFacade
    {
        Lights lights;
        MusicSystem musicSystem;
        TV tv;
        public HomeFacade()
        {
            lights = new Lights();
            musicSystem = new MusicSystem();
            tv = new TV();
        }

        /// <summary>
        /// Leaves the home.
        /// </summary>
        public void LeaveHome()
        {
            Console.WriteLine("******LEAVING HOME*********");
            lights.SwitchOffLights();
            tv.switchOffTV();
            musicSystem.SwitchOffMusicSystem();
        }

        /// <summary>
        /// Arrives the home.
        /// </summary>
        public void ArriveHome()
        {
            Console.WriteLine("*********ARRIVED HOME********");
            lights.SwitchOnLights();
            tv.switchOnTV();
            musicSystem.SwitchOnMusicSystem();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Lights
    {
        /// <summary>
        /// Switches the on lights.
        /// </summary>
        public void SwitchOnLights()
        {
            Console.WriteLine("lights switched ON");
        }

        /// <summary>
        /// Switches the off lights.
        /// </summary>
        public void SwitchOffLights()
        {
            Console.WriteLine("lights switched OFF");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class MusicSystem
    {
        /// <summary>
        /// Switches the on music system.
        /// </summary>
        public void SwitchOnMusicSystem()
        {
            Console.WriteLine("muscic system switched ON");
        }

        /// <summary>
        /// Switches the off music system.
        /// </summary>
        public void SwitchOffMusicSystem()
        {
            Console.WriteLine("muscic system switched Off");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TV
    {
        /// <summary>
        /// Switches the on tv.
        /// </summary>
        public void switchOnTV()
        {
            Console.WriteLine("TV Switched ON");
        }

        /// <summary>
        /// Switches the off tv.
        /// </summary>
        public void switchOffTV()
        {
            Console.WriteLine("TV Switched OFF");
        }
    }
}
