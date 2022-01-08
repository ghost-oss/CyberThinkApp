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

            passwordeModulesList = new List<Module>();
            passwordeModulesList.Add(new Module()
            {
                moduleName = "Password Overview",
                moduleInformation = "A password is simply the most convenient (and easiest) way to protect our devices. It is a means by which a user proves they are authorised to use a device. Great, it’s secure…but how secure is it? The modules going forward will consolidate your understanding on how weak passwords can be exploited and how you can implement secure passwords!\n\n" +
                "With modern technology, computing devices connect and share information around the globe, and they may also connect with financial transactions. These devices are all vulnerable to unauthorised users. The consequences of the victims or organisations who encounter a break-in may include financial loss, loss of reputability or even personal records. It is crucial that passwords are securely managed, contain some complexity and is difficult for an adversary to guess.\n\n",
                isComplete = false
            });

            passwordeModulesList.Add(new Module()
            {
                moduleName = "Password Attacks",
                moduleInformation = "Brute-Force Attack:\n" +
                "A brute-force is a type of attack whereby every permutation of a password is tested against a password protected system. An attacker may tailor the attack such as specificizing only attempting numbers or simply words. Once the attack is initiated, it is only constrained by the computational power of the adversary, and multiple attempts are made to breach the user’s account\n\n" +
                "Dictionary Attacks:\n" +
                "This technique uses trial-and-error to guess valid user credentials. An attacker may submit a list of commonly used words, namely usernames and passwords with the intention of getting a correct match.\n\n" +
                "Most dictionary attacks are executed by deploying some automated software which allows vast quantities of passwords to be fed into the system. Common passwords include: password123, 123456, letmein, batman and others.\n\n" +
                "Shoulder Surfing:\n" +
                "Should surfing is also common against workplaces. Shoulder surfing may involve a colleague watching over your shoulder to obtain valuable information. In a work environment, this may most likely be your username and password as you key It within an electronic device.\n\n" +
                "Local Discovery:\n" +
                "This technique is often seen in a targeted attack. The adversary may have some relation to you within a workplace. Local Discovery attack occurs when a user writes their password down which can be seen by anyone in plain-text form. Often without your knowledge or consent, the password is then leaked and utilised in a malicious way. Scary right?\n\n" +
                "Guessing\n" +
                "If all fails, hackers may resort to try to simply guess your password. This is often seen as many users rely on memorable phrases. These phrases are often related to locations, hobbies, interests, pets; much which is already exposed through other means such as social profiles.\n\n",
                isComplete = false
            });

            passwordeModulesList.Add(new Module()
            {
                moduleName = "Secure Techniques",
                moduleInformation = "Longer Passwords:\n" +
                "The password that you utilise should be at a minimum of 8 characters long, although for additional security this could be longer. This is the general baseline when creating a password and yields greater security, making it difficult for an adversary to guess.\n\n" +
                "Increased Complexity:\n" +
                "The password should include a combination of alphabets, numbers, symbols, uppercase and lowercase letters. This will strengthen the password and reduce the chances of being exploited from a brute-force or dictionary attack as there would exist too many combinations for an attacker to consider.\n\n" +
                "Prevent Using Personal Information:\n" +
                "Never use phrases such as your name, birthday, username, or hobbies. These types of information are usually held publicly which will make it easier for an adversary to obtain and crack. Whilst you can pad common phrases with other values such as ‘992Football21’, this is still considered insecure than opting for a random password string such as ‘kUD!9#oU’ which employees greater security.\n\n" +
                "Don’t use same password for each account:\n" +
                "You should prevent using the same password for every account. Having a single leak of password anywhere would put every other account at risk. Hackers will inevitably attempt other sites to steal further information.\n\n" +
                "Password Manager:\n" +
                "If you are afraid to lose your password, then a password manager is the way to go. This piece of software is an encrypted digital vault that securely stores your login information. This software can then be used to access your personal accounts on your device, websites, and other services.\n\n" +
                "There are many password managers which also generate unique and strong passwords to ensure you are not using the same passwords within other domains. A single password manager can reduce your chances of being exploited by a large margin.\n\n" +
                "Be smart:\n" +
                "One of the biggest vulnerabilities known to an adversary are people. Be smart when logging in or using personal credentials publicly. Never disclose any private information that could lead to a breach and under any circumstances do not share your password!\n\n",
                isComplete = false
            });



            phishingModulesList = new List<Module>();
            phishingModulesList.Add(new Module()
            {
                moduleName = "Introduction",
                moduleInformation = "Phishing attacks are a subsidiary of social engineering attack, and they consist of various targets depending on the adversary. Attackers may mask themselves as a legitimate representative to gain further information, often leading to theft of identity or notable financial loss.\n\n" +
                "This type of cyber-attack may utilise technology such as email, mobile device, or text messages to lure individuals into releasing confidential information. The information could range from passwords, credit card numbers, national security numbers or even details about the individual or organisation. \n\n" +
                "The following modules will give you an understanding of the different type of phishing techniques an attacker may use against you and how you can protect yourself from phishing attacks within a workplace.\n\n",
                isComplete = false
            });

            phishingModulesList.Add(new Module()
            {
                moduleName = "Phishing Attacks",
                moduleInformation = "Email Phishing:\n" +
                "Email Phishing is the most common attack vector for an attacker to exploit. This technique involves an adversary to impersonate a legitimate organization and sends mass emails to as many addresses as possible.\n\n" +
                "The beginning of the email usually has no specific name and is usually placed with ‘Dear Customer’ or ‘To Whom It May Concern’. Additionally, the contents within the email are generic.\n\n" +
                "The email is constructed with some sense of urgency, which would inform the victim that their account has been hijacked or comprised. The aim of this email would attempt to lure the victim to respond immediately. Often, these emails are attached with URL’s which link to a counterfeit website with Malware.\n\n" +
                "Spear phishing:\n" +
                "Spear Phishing is considered a targeted attack. Rather than sending out mass malicious emails and links to everyone, this method targets specific employees who reside in specific companies.\n\n" +
                "An adversary usually carries out this attack by customizing their payload such as an email with the victim’s name, company, work phone number, and other data to trick the victim into believing that there is a genuine connection with the sender. Yet, the goal is the same which gets the victim to release confidential information or click a malicious attachment.\n\n" +
                "Whaling:\n" +
                "Whaling is a technique which closely relates to spear phishing, however instead of targeting an employee within a cooperation, an adversary would target a senior executive. These types of attacks may target a CEO, CFO, or any senior member within an institution. The emails often use some high-pressure circumstances to entice the victim. Examples include the company being sued.\n\n" +
                "Smishing:\n" +
                "SMS phishing, commonly known as smishing, involves an attacker using text messages to carry out an attack. This attack operates on the same basis as an email phishing attack but send text messages to victims masking as a legitimate source which contain malicious links. Examples include fake coupon codes, lottery tickets or chance to win a prize.\n\n" +
                "Vishing:\n" +
                "Voice phishing, commonly known as vishing, involves an attacker using a phone to exploit a victim. An attacker usually relays a voice message which may impersonate a legitimate institution such as the government to entice the victim to handing over detail.\n\n" +
                "In a workplace, a common example could include a call from another institution who require further information for a successful partnership. They would then go to ask details of the organisation and yourself to gain a further insight. Be wary of these!\n\n",
                isComplete = false
            });

            phishingModulesList.Add(new Module()
            {
                moduleName = "Defensive Techniques",
                moduleInformation = "Phishing:\n" +
                "Investigate the email before responding. You may start by analysing the ‘From’ field and dictate whether the sender’s name has been misspelt or been padded with extra characters. Next, be sure to verify the email address domain and dictate whether it is genuine. An example of a fake email domain is Microsoft.co.o.\n\n" +
                "Read the email and look for any malicious text, links and any request seeking personal information. Validate if the email is free of any spelling errors or odd grammar and think about the urgency of the message. Review if the time coincides with the event that has been raised and any unusual personal information requested.\n\n" +
                "HTTP and HTTPS Links:\n" +
                "Most institutions will use Hypertext Transfer Protocol Secure (HTTPS) rather than HTTP as it establishes legitimacy. However, cyber-criminals have adapted and utilise HTTPS to trick the victim to click on counterfeit links.\n\n" +
                "A spoofed link will often be shortened. Therefore, ensure the link is in the original, long-tail format and reveals the whole URL. Secondly, evaluate the URL and consider any misspellings or wrong domain use. Finally, hover over the link and dictate whether the source is indeed correct.\n\n" +
                "Vishing:\n" +
                "An adversary may often represent themselves as a fake organisation such as the government. Federal institutions will never contact you unless requested therefore it is imperative to be weary for such calls.\n\n" +
                "Think about the sense of urgency as a fraudster may tap your sense of fear and use threats to get you to release information! Be weary of the information a caller may request such as your name, address, and birth date.\n\n" +
                "You can protect yourself from vishing by simply declining the phone call or listening to the voice mail and determining to call back. Secondly, you can verify the caller’s identity and call the company directly to evaluate the legitimacy. Finally, the moment you suspect a vishing call then it may be appropriate to politely hang up.\n\n" +
                "Smishing:\n" +
                "Do not assume as text is genuine due to its perfectly constructed grammar. Smishing is easier to mask as a legitimate organisation as it is shorter than emails. The object of smishing is to click a link, therefore validate the link and the link-domain.\n\n" +
                "Never share personal information via text as if it is urgent than an organization may contact you in a more appropriate manor such as email or phone call. Thirdly, you can search the organization and visit their website directly or phone them using a trusted telephone number.\n\n",
                isComplete = false
            });


            physicalModulesList = new List<Module>();
            physicalModulesList.Add(new Module()
            {
                moduleName = "Overview",
                moduleInformation = "Not all cyber threats begin within the digital realm, and it is imperative to understand they can begin within your physical workspace. An adversary may physically access your workplace or potentially performing actions to gain access to unauthorised areas. They may continue to then leverage their situation and extract large pieces of information and utilise it to support future cyber-attacks.\n\n" +
                "Physical security is imperative for an organization as it protects and safeguards company personnel, data and physical hardware from adversaries who could damage and disrupt the operations with a business. It ensures that physical properties are protected from threats such as theft, damage and even modifications.\n\n" +
                "The following modules will consolidate your understanding on secure workplace hygiene, physical tailgating, and how an attacker could potentially exploit these vectors.\n\n",
                isComplete = false
            });

            physicalModulesList.Add(new Module()
            {
                moduleName = "Secure Workplace Hygiene",
                moduleInformation = "Securing Workstations:\n" +
                "Your workstation is an area which you utilise to device business strategy and solutions. Your given workstation should be clean, de-clustered of any exposed documents and sticker notes which may contain password or hints. Additionally, all sensitive documents must be stored within a file cabinet and any documents no long in use must be shredded.\n\n" +
                "If an adversary acquired confidential documents in a workplace, they could leak it to unauthorised users and seriously damage the reputation of the business. This could adversely affect potential partnerships, stakeholders, or financial gain.\n\n" +
                "Device Usage:\n" +
                "Whenever the desk is not in use, you must disconnect or alternatively log out of the device you are connected to. Leaving your PC logged in could easily be accessible to an adversary who could tamper with the device and extract valuable information. Notably, an attacker could also perform an attack which implicates you!\n\n" +
                "Personal Belongings:\n" +
                "Ensure when you are away from the desk or moving around the workplace, your belongings are always kept in a safe area. Items such as your employee badge should always be worn around your neck and personal devices should be kept locked. A loose badge could be stolen and used by an adversary to access unauthorised premises\n\n" +
                "Vigilance:\n" +
                "You must ensure to remain vigilant within a workplace and use your own initiative during suspicious circumstances. If a suspicious activity is detected, you must immediately follow security protocols and report It to a senior member. If there is a doubt, then shout!\n\n" +
                "Procedures:\n" +
                "You must also respect company security protocols and guidelines. For example, under no circumstances should you share your employee ID or badge to bypass any security entry points. A good employee should educate the co-worker of the security policy procedure for those who have lost their card.\n\n" +
                "Finally, to be kept up to date with all security procedures, it is imperative to attend security training programs. This will keep you up to date with all security related processes, raise any new security concerns and educate you to tackle suspicious activity appropriately.\n\n",
                isComplete = false
            });

            physicalModulesList.Add(new Module()
            {
                moduleName = "Tailgaiting",
                moduleInformation = "The tailgating technique involves an attacker gaining unauthorised access to the business premises by following an employee typically from behind. The attacker can perform two objectives from this action:\n\n" +
                "1. They can leverage their situation by providing further reconnaissance on the organisation to support future cyber-attacks and use social engineering to collect further data such as employee names and confidential documents.\n\n" +
                "2. The attacker at this point may also be able to access unauthorised areas and tamper with physical hardware to cause destruction. These areas entail of Server Rooms and/or Networking hardware, which could potentially grant them access to business systems.\n\n" +
                "A typical scenario of social engineering could include an attacker exploiting your empathy. An adversary may lie about ‘forgetting’ their employee ID and request you to permit entry to an unauthorised area. Security mechanisms should be enforced to prevent these situations. Examples include:\n\n" +
                "Employee Badge - A plastic card which proves your identification and displays necessary information which can be easily identifiable to other employees. This could include your name, employee number and a photo.\n\n" +
                "Physical Access Control - These devices are usually allocated next to entry points of the organisation. This requires an authorised badge to be scanned and dictates whether he/she is permitted to access the facilities behind the entry point.\n\n",
                isComplete = false
            });
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

       

