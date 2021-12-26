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
                moduleInformation = "Phishing:\n" +
                "Over 70% of cyber-attacks begin with phishing. Hackers love this technique to steal user credential and use for their own purposes or to sell into the black market!\n\n" +
                "Phishing is a social engineering technique which tricks a user into supplying their information to what they believe is a genuine request from a website or vendor. This attack may be proposed through emails with fraudulent links, cloned websites, or a malicious attachment.\n\n" +
                "Adversaries will then use some man-in-the-middle attack to intercept your input and take them away. \n\n" +
                "Brute-Force attacks:\n" +
                "This technique uses trial-and-error to guess valid user credentials. An attacker may submit a list of commonly used usernames and passwords with the intention of getting a correct match. Most brute-force attacks are executed by deploying some automated software which allows vast quantities of username and passwords to be fed into the system. Common passwords include: password123, 123456, letmein, batman and others.\n\n" +
                "Shoulder Surfing:\n" +
                "Should surfing is also common against workplaces. Shoulder surfing may involve a college watching over your shoulder to obtain valuable information. In a work environment, this may most likely be your username and password as you key It within an electronic device.\n\n",
                isComplete = false });


            passwordeModulesList.Add(new Module() { moduleName = "Topic 3", moduleInformation = "Some information", isComplete = false });

















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

       

