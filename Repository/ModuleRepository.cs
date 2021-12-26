//NOTE USING THIS REPO ANYMORE
using System;
using System.Collections.Generic;
using System.Linq;

using CyberThink.Model;

namespace CyberThink.Repository
{
    public class ModuleRepository
    {
        private List<Module> phishingModulesList;
        private List<Module> passwordeModulesList;
        private List<Module> physicalModulesList;


        public void GenerateModules()
        {
            phishingModulesList = new List<Module>();

            passwordeModulesList = new List<Module>();
            passwordeModulesList.Add(new Module() { moduleName = "Password Overview",
                moduleInformation = "A password is simply the most convenient (and easiest) way to protect our devices. It is a means by which a user proves they are authorised to use a device. Great, it’s secure…but how secure is it? The modules going forward will consolidate your understanding on how weak passwords can be exploited and how you can implement secure passwords!\n\n" +
                "With modern technology, computing devices connect and share information around the globe, and they may also connect with financial transactions. These devices are all vulnerable to unauthorised users. The consequences of the victims who encounter a break-in include loss of information, emails, music, or even personal records. It is crucial that passwords are securely managed, contain some complexity and is difficult for an adversary to guess.",
                isComplete = false });

            passwordeModulesList.Add(new Module() { moduleName = "Password Attacks",
                moduleInformation = "Phishing:\n"+
                "Over 70% of cyber-attacks begin with phishing. Hackers love this technique to steal user credential and use for their own purposes or to sell into the black market!\n\n" +
                "Phishing is a social engineering technique which tricks a user into supplying their information to what they believe is a genuine request from a website or vendor. This attack may be proposed through emails with fraudulent links, cloned websites, or a malicious attachment.\n\n" +
                "Adversaries will then use some man-in-the-middle attack to intercept your input and take them away. \n\n" +
                "Brute-Force attacks:\n" +
                "This technique uses trial-and-error to guess valid user credentials. An attacker may submit a list of commonly used usernames and passwords with the intention of getting a correct match. Most brute-force attacks are executed by deploying some automated software which allows vast quantities of username and passwords to be fed into the system. Common passwords include: password123, 123456, letmein, batman and others.\n\n" +
                "Shoulder Surfing:\n" +
                "Should surfing is also common against workplaces. Shoulder surfing may involve a college watching over your shoulder to obtain valuable information. In a work environment, this may most likely be your username and password as you key It within an electronic device.\n\n" +
                "Local Discovery:\n" +
                "This technique is often seen in a targeted attack. The adversary may have some relation to you within a workplace.\n\n" +
                "Local Discovery attack occurs when a user writes their password down which can be seen by anyone in plain-text form. Often without your knowledge or consent, the password is then leaked and utilised in a malicious way. Scary right?\n\n" +
                "Guessing\n" +
                "If all fails, hackers may resort to try to simply guess your password. This is often seen as many users rely on memorable phrases. These phrases are often related to locations, hobbies, interests, pets; much which is already exposed through other means such as social profiles.\n\n",
                isComplete = false });

            passwordeModulesList.Add(new Module() { moduleName = "Secure Techniques",
                moduleInformation = "Use Longer password with different characters:\n" +
                "The password that you utilised should be at a minimum of six characters long, although for additional security it could be even longer. Additionally, the password should contain a mixture of alphabets, numbers, symbols with a combination of uppercase and lowercase letters.\n\n" +
                "Prevent Using Personal Information:\n" +
                "Never use phrases such as your name, birthday, username, or email. These types of information are usually held publicly which will make it easier for an adversary to obtain.\n\n" +
                "Don’t use same password for each account:\n" +
                "You should prevent using the same password for every account held. Having a single leak of password anywhere would put every other account at risk. Hackers will inevitably attempt other sites to steal further information.\n\n" +
                "Password Manager:\n" +
                "If you are afraid to lose your password, then a password manager is the way to go. This piece of software is an encrypted digital vault that securely stores your login information. This software can then be used to access your personal accounts on your device, websites, and other services.\n\n" +
                "There are many password managers which also generate unique and strong passwords to ensure you are not using the same passwords within other domains. A single password manager can reduce your chances of being exploited by a large margin.\n\n" +
                "Be smart:\n" +
                "One of the biggest vulnerabilities known to an adversary are people. Be smart when logging in or using personal credentials publicly. Never disclose any private information that could lead to a breach and under any circumstances do not share your password.\n\n",
                isComplete = false });

            


            phishingModulesList.Add(new Module() {moduleName = "Cyber Security Basics",
                moduleInformation = "Cyber Security is the practice to which computers, mobile devices, systems, network and data are protected from malicious attackers. This is also known as information technology security.\n\n" +
                "In order to protect the technology domain, you must understand and comply with basic data security principles like choosing strong passwords, being wary of malicious email attachments, phishing and a whole lot more!\n\n" +
                "In today’s world everyone benefits from the internet however not enforcing security measures can lead to anything from identity theft, loss of data and even up to national attacks! It’s up to you to learn these concepts and how to make your workplace as safe as possible.",
                isComplete = false });
            phishingModulesList.Add(new Module() { moduleName = "Topic 2", moduleInformation = "Some information", isComplete = false });
            phishingModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });

         
            physicalModulesList = new List<Module>();
            physicalModulesList.Add(new Module() { moduleName = "Topic 1", moduleInformation = "Some information", isComplete = false });
            physicalModulesList.Add(new Module() { moduleName = "Topic 2", moduleInformation = "Some information", isComplete = false });
            physicalModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });
        }


        public List<Module> RetrieveModuleList(string moduleType)
        {
            if (moduleType == "PhishingModules")
            {
                return phishingModulesList;
            }
            else if (moduleType == "PasswordModules")
            {
                return passwordeModulesList;
            }
            else
            {
                return physicalModulesList;
            }
        }
    }
}

       

