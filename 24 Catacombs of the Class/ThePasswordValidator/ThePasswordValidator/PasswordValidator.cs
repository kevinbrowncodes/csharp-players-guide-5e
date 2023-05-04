using System;
namespace ThePasswordValidator
{
	/* Define a new PasswordValidator class that can be given a password
	 * and determine if the password follows the rules */
	public class PasswordValidator
	{
		public string _password;
        public bool _validPassword;

		public string Password
		{
			get => _password;
			set => _password = value;
        }

        public bool ValidPassword
        {
            get => _validPassword;
            private set => _validPassword = false;
        }

		public PasswordValidator(string passwordInput)
		{
            this.ValidPassword = CheckPassword(passwordInput);


            //checkPasswordLengthRule();
            /// lowercase letter, and one number
            //checkCharacterRule();
            /// password cannot contain a capital T or an ampersand (&)
            /// because Ingelmar in IT has decreed it.
            //checkCustomRule();

        }

		public bool CheckPassword(string passwordInput)
		{
            bool isValidPassword = false;
            bool isValidPasswordInputLength = false;
            bool isValidPasswordCharacter = false;
            bool isValidPasswordCustomIT = false;

            isValidPasswordInputLength = CheckPasswordLengthRule(passwordInput);
            isValidPasswordCharacter = CheckPassowrdCharacterRule(passwordInput);
            isValidPasswordCustomIT = CheckPassowrdCustomIT(passwordInput);

            if (isValidPasswordInputLength && isValidPasswordCharacter && isValidPasswordCustomIT)
            {
                isValidPassword = true;
            }

            return isValidPassword;
        }

        /// <summary>
        /// password must be at least 6 letters long and no more than 13
        /// letters long
        /// </summary>
        /// <returns></returns>
        public bool CheckPasswordLengthRule(string passwordInput)
		{
			int passwordInputLength;
			bool isValidPasswordLength = false;
            int passwordLengthMin = 6;
            bool isValidPasswordLengthMin = false;
            int passwordLengthMax = 13;
            bool isValidPasswordLengthMax = false;

            // at least 6 letters long
            passwordInputLength = passwordInput.Length;

			if(passwordLengthMin <= passwordInputLength)
			{
                isValidPasswordLengthMin = true;
            }

            // no more than 13 letters long
            if (passwordLengthMax > passwordInputLength)
			{
                isValidPasswordLengthMax = true;
            }

            if(isValidPasswordLengthMin && isValidPasswordLengthMax)
            {
                isValidPasswordLength = true;
            }

			return isValidPasswordLength;

        }

        /// <summary>
        /// password must contain at least one uppercase letter, one
        /// lowercase letter, and one number 
        /// </summary>
        /// <param name="passwordInput"></param>
        /// <returns></returns>
        public bool CheckPassowrdCharacterRule(string passwordInput)
        {
            bool isValidPasswordCharacter = false;
            bool containsUppercaseLetter = false;
            bool containsLowercaseLetter = false;
            bool containsNumber = false;

            // at least one uppercase letter
            for (int i = 0; i <= passwordInput.Length - 1; i++)
            {
                char charInput = passwordInput[i];

                
                if (char.IsUpper(charInput))
                {
                    containsUppercaseLetter = true;
                    break;
                }
            }

            // at least one lowercase letter
            for (int i = 0; i <= passwordInput.Length - 1; i++)
            {
                char charInput = passwordInput[i];

                if (char.IsLower(charInput))
                {
                    containsLowercaseLetter = true;
                    break;
                }
            }

            // at least one number
            for (int i = 0; i <= passwordInput.Length - 1; i++)
            {
                char charInput = passwordInput[i];

                if (char.IsNumber(charInput))
                {
                    containsNumber = true;
                    break;
                }
            }

            if (containsUppercaseLetter && containsLowercaseLetter && containsNumber)
            {
                isValidPasswordCharacter = true;
            }

            return isValidPasswordCharacter;
        }

        /// <summary>
        /// password cannot contain a capital T or an ampersand (&)
        /// because Ingelmar in IT has decreed it.
        /// </summary>
        /// <param name="passwordInput"></param>
        /// <returns></returns>
        public bool CheckPassowrdCustomIT(string passwordInput)
        {
            bool isValidPasswordCustomIT = false;
            bool containsT = false;
            bool containsAmpersand = false;

            // contains capital T
            for (int i = 0; i <= passwordInput.Length - 1; i++)
            {
                if ('T' == passwordInput[i])
                {
                    containsT = true;
                    break;
                }
            }

            // contains ampersand
            for (int i = 0; i <= passwordInput.Length - 1; i++)
            {
                if('&' == passwordInput[i])
                {
                    containsAmpersand = true;
                    break;
                }
            }

            if (!containsT && !containsAmpersand)
            {
                isValidPasswordCustomIT = true;
            }

            return isValidPasswordCustomIT;

        }

    }
}

