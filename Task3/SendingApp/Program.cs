using SendingClasses;

Email email = new Email("I'm a subject","h_kim@utb.cz","I'm a content");
email.AddRecipent("kim@utb.cz");
email.AddRecipent("hyeonsu@utb.cz");
email.Send();

SMS sms = new SMS("774123456","I'm a content");
sms.Send();

