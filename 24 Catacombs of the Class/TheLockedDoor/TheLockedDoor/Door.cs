using System;
namespace TheLockedDoor
{
	/* Define a Door class that can keep track of whether it is locked,
	 * open, or closed . */
	/* Mkae it so you can preform the four transitions defined above
	 * with methods */
	/// <summary>
	/// Build a Door
	/// </summary>
	public class Door
	{
		// fields
		private DoorStatus _doorStatus = DoorStatus.Locked;
		private string? _passcode;
        private bool _isLocked = true;

		// properties
		public DoorStatus DoorStatus
		{
			get => _doorStatus;
			set => _doorStatus = value;
		}
        public bool IsLocked
        {
            get => _isLocked;
            private set => _isLocked = value;
        }
        private string Passcode
        {
            get => _passcode;
            set => _passcode = value;
        }

		// constructors
		public Door() {}

		/* Build a constructor that requires the starting numeric passcode */
		public Door(string passcode)
		{
			_passcode = passcode;
        }

		// methods
		private void openDoor(DoorStatus currentDoorStatusRequest)
		{
			// open
			if((this.DoorStatus == DoorStatus.Opened) && (currentDoorStatusRequest == DoorStatus.Opened))
			{
				this.DoorStatus = DoorStatus.Opened;

            }
            // close
            else if ((this.DoorStatus == DoorStatus.Closed) && (currentDoorStatusRequest == DoorStatus.Opened))
            {
                this.DoorStatus = DoorStatus.Opened;

            }
            // lock
            else if ((this.DoorStatus == DoorStatus.Locked) && (currentDoorStatusRequest == DoorStatus.Opened))
            {
                this.DoorStatus = DoorStatus.Locked;

            }
			// default
			else
            {
              this.DoorStatus = DoorStatus.Locked;
            }
        }
        private void closeDoor(DoorStatus currentDoorStatusRequest)
        {
            // open
            if ((this.DoorStatus == DoorStatus.Opened) && (currentDoorStatusRequest == DoorStatus.Closed))
            {
                this.DoorStatus = DoorStatus.Closed;

            }
            // close
            else if ((this.DoorStatus == DoorStatus.Closed) && (currentDoorStatusRequest == DoorStatus.Closed))
            {
                if (!this.IsLocked)
                {
                    this.DoorStatus = DoorStatus.Closed;
                }
                else if (this.IsLocked)
                {
                    this.DoorStatus = DoorStatus.Locked;
                }
                else
                {
                    this.DoorStatus = DoorStatus.Locked;
                }
            }
            // lock
            else if ((this.DoorStatus == DoorStatus.Locked) && (currentDoorStatusRequest == DoorStatus.Closed))
            {
                if (!this.IsLocked)
                {
                    this.DoorStatus = DoorStatus.Locked;
                }
                else if (this.IsLocked)
                {
                    this.DoorStatus = DoorStatus.Locked;
                }
                else
                {
                    this.DoorStatus = DoorStatus.Locked;
                }
            }
            // default
            else
            {
                this.DoorStatus = DoorStatus.Locked;
            }
        }
        private void lockDoor(DoorStatus currentDoorStatusRequest)
        {
            // open
            if ((this.DoorStatus == DoorStatus.Opened) && (currentDoorStatusRequest == DoorStatus.Locked))
            {
                this.DoorStatus = DoorStatus.Opened;

            }
            // close
            else if ((this.DoorStatus == DoorStatus.Closed) && (currentDoorStatusRequest == DoorStatus.Locked))
            {
                this.DoorStatus = DoorStatus.Locked;

            }
            // lock
            else if ((this.DoorStatus == DoorStatus.Locked) && (currentDoorStatusRequest == DoorStatus.Locked))
            {
                this.DoorStatus = DoorStatus.Locked;

            }
            // default
            else
            {
                this.DoorStatus = DoorStatus.Locked;
            }
        }
        private void unlockDoor()
        {
            bool isValidPasscode = false;
            isValidPasscode = checkPasscode();

            if (isValidPasscode)
            {
                Console.WriteLine("\nPasscode is valid and the door is unlocked.");
                this.IsLocked = false;
                this.DoorStatus = DoorStatus.Closed; 
            }
            else
            {
                Console.WriteLine("\nPasscode is invalid and the door is locked.");
            }
        }

        public DoorStatus DoorRequestToDoorStatus(string? doorRequest)
        {
            if (doorRequest == null)
            {
                return DoorStatus.Locked;
            }

			switch (doorRequest)
			{
				case "Open":
                    return DoorStatus.Opened;
				case "Close":
					return DoorStatus.Closed;
                case "Lock":
					return DoorStatus.Locked;
				default:
                    return DoorStatus.Locked;
            }
        }

		public void UpdateDoorStatus(string currentDoorRequest)
		{
            if(currentDoorRequest == "Unlock")
            {
                unlockDoor();
            }

            if (currentDoorRequest == "Change Passcode")
            {
                changePasscode();
            }

            if (!this.IsLocked && currentDoorRequest != "Unlock")
            {
                DoorStatus currentDoorStatus = DoorRequestToDoorStatus(currentDoorRequest);

                switch (currentDoorStatus)
                {
                    case DoorStatus.Opened:
                        openDoor(currentDoorStatus);
                        break;
                    case DoorStatus.Closed:
                        closeDoor(currentDoorStatus);
                        break;
                    case DoorStatus.Locked:
                        lockDoor(currentDoorStatus);
                        break;
                    default:
                        lockDoor(currentDoorStatus);
                        break;
                }
            }
        }

        /* Build a method that will allow you to change the passcode for an existing door by supplying the current passcode and new passcode. Only change the passcode if the current passcode is correct. */
        private void changePasscode()
        {
            string passcodeNew;
            bool isValidPasscode = false;

            isValidPasscode = checkPasscode();

            if (isValidPasscode)
            {
                Console.WriteLine("\nWhat is new passcode? ");
                passcodeNew = Console.ReadLine();
                this.Passcode = passcodeNew;
            }
            else
            {
                Console.WriteLine("\nCannot change passcode!");
            }
        }      

        private bool checkPasscode() {
            string passcodeInput;
            bool isValid = false;

            Console.WriteLine("\nWhat is current passcode? ");
            passcodeInput = Console.ReadLine();

            if(this.Passcode == passcodeInput)
            {
                Console.WriteLine("\nValid Passcode");
                isValid = true;
                return isValid;
            }
            else
            {
                Console.WriteLine("\nInvalid Passcode");
                return isValid;

            }


        }
    }
}

