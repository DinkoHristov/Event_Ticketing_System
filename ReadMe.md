# Workshop: Implementing Application Flow & Middlewear and Working with Data

Workshop description for the ["ASP.NET Core" course @ SoftUni](https://softuni.bg/courses/asp-net-mvc).

1.
# Application Flow & Middleware

## Eventures

**Eventures**** Inc **. is a fast-rising newly made Start-Up Company, which specializes in** Event Tickets Sales**. It is said to be the killer of systems like Eventim, Eventbride, etc.

You have been appointed as the developer of the **main web application**. This is a great responsibility, so do your best and do not dissapoint your employers. The application functionality is not that complex, and it will be **separated** into **several parts**, each part consisting of **several tasks**.

Your current task is to create the **architecture** and **core logic** of the **application**, so get started.

## 1.Data Storage

The core application logic requires **2 data models** to be implemented:

### User

Has the following properties:

- **Username**– a **string**(from **IdentityUser**) **.**
- **Password**– a **string**(from **IdentityUser**) **.**
- **Email**– a **string**(from **IdentityUser**) **.**
- **First**** Name **– a** string**.
- **Last**** Name **– a** string**.
- **Unique**** Citizen ****Number**( **UCN**) – a **string**.
- **Role**–can be **User****/ ****Admin**

### Event

Has the following properties:

- **Id**– a **UUID**.
- **Name**– a **string**.
- **Place**– a **string**.
- **Start**– a **DateTime** object.
- **End**– a **DateTime** object.
- **Total**** Tickets **– an** integer**.
- **Price**** Per ****Ticket**– a **decimal** value.

## 2.Front-End

The Front-End might be a little different in some small components than the things you've done so far. However, do not panic, it is not that hard to do it. You can do it! ??

There are a few templates you must implement, they are not that much, but they are tricky.

### Index Template

![](RackMultipart20240418-1-rz3zmt_html_5c318839d5e69adb.png)

### Login Template

![](RackMultipart20240418-1-rz3zmt_html_34ab33580d05e542.png)

The **Forgot**** your ****password?** Is a just a link with no functionality, for now.

### Register Template

![](RackMultipart20240418-1-rz3zmt_html_b73f2448d00abca3.png)

### Home (logged-in users)

![](RackMultipart20240418-1-rz3zmt_html_e1fa81fea5d70937.png)

### All Events (logged-in)

![](RackMultipart20240418-1-rz3zmt_html_bf69b27a7d76d9d7.png)

### Admin Home (logged-in Admin)

![](RackMultipart20240418-1-rz3zmt_html_3d6961bef0cc9ea2.png)

#### Admin Navigation

![](RackMultipart20240418-1-rz3zmt_html_2f6caf223e801135.png)

### Create Events

![](RackMultipart20240418-1-rz3zmt_html_2a0460c626eada7d.png)

**Note**: The color for the application is **#AFEEEE**.

## 3.Business Logic

### Technical Requirements

The application should be an **ASP.NET Core Web** app. As such it should use **the most** of the **ASP.NET Core Framework**.

Use **ASP.NET Core Identity** for authentication. Add the following **roles** to your **User** functionality – (' **USER**', ' **ADMIN**').

### Functionality

The application should provide its **Guest** users ( **not logged-in**) the functionality to **register** and **login**.

The application should provide its **Regular** users ( **logged-in**** Users **with** Role **–** User**) the functionality to**view all **** Events**.

The application should provide its **Admin** users ( **logged-in**** Users **with** Role **–** Admin**) the functionality to**create ****new**** Events **,** view all **** Events**.

## 4.Middleware

Create a **Middleware**, which **seeds** the **database** upon **Application startup**. It should **seed** the database with the **Roles** and it should seed a single **Admin User**.

## 5.Filters

Create an **ActionFilter** which **Logs** each **Admin**** Create ****Event** activity, after the action itself. The log should output a single message:

**[{currentDateAndTime}] Administrator {Username} create event {EventName} ({EventStart} / {EventEnd}).**

1.
# Working with Data

## 6.Data Validation

Implement **data validation** for the **data models** which are **affected** by **user input**( **User**, **Event**).

### User

The following data constraints should be present:

**Username**

- Should **NOT** be **NULL**.
- Should be **at least 3 symbols long**.
- May only contain:
  - **alphanumeric characters**
  - **dashes** and **underscores**
  - **dots**, **asterisks** and **tildes**

**Password**

- Should **NOT** be **NULL**.
- Should be **at least 5 symbols long**.
- May contain **any** character.

**Email**

- Should **NOT** be **NULL**.
- Should be a valid **email**.

**Unique Citizen Number(UCN)**

- Should **NOT** be **NULL**.
- Should consist of **exactly**** 10 numbers**.

### Event

**Name**

- Should **NOT** be **NULL**.
- Should be **at least 10 symbols long**.
- May contain **any** character.

**Place**

- Should **NOT** be **NULL**.
- Should **NOT** be **empty**.
- May contain **any** character.

**Start**

- Should **NOT** be **NULL**.
- Should be a **valid date**.

**End**

- Should **NOT** be **NULL**.
- Should be a **valid date**.

**Total Tickets**

- Should **NOT** be **NULL**.
- Should be a **non-zero integer number**.

**Price per Ticket**

- Should **NOT** be **NULL**.
- Should be a **decimal number**.

## 7.Error Handling

Implement basic **error handling** in the **Eventures** application.

Instead of handling **binding errors** or any other **request-connected errors** in the **Controllers**, throw **exceptions** and **handle** them with **error**** handlers**.

Implement **custom view pages** for the **errors**, so that you could provide the client with a **suitable response**.

![Shape3](RackMultipart20240418-1-rz3zmt_html_6f222e41d7629786.gif) ![Shape2](RackMultipart20240418-1-rz3zmt_html_5f0f2ddacbac70d2.gif) ![Shape1](RackMultipart20240418-1-rz3zmt_html_51bd00be29b85496.gif) ![Shape4](RackMultipart20240418-1-rz3zmt_html_f746d52952cd7e91.gif)[![](RackMultipart20240418-1-rz3zmt_html_3aa486326bfa75e9.png)](https://softuni.org/)

Follow us:

© SoftUni – [about.softuni.bg](https://about.softuni.bg/). Copyrighted document. Unauthorized copy, reproduction or use is not permitted.

[![](RackMultipart20240418-1-rz3zmt_html_9b17934bfedeb713.png)](https://softuni.org/)[![](RackMultipart20240418-1-rz3zmt_html_c9db196993f48ff8.png)](https://softuni.bg/)[![Software University @ Facebook](RackMultipart20240418-1-rz3zmt_html_94be3df36d913358.png)](https://www.facebook.com/softuni.org)[![](RackMultipart20240418-1-rz3zmt_html_7e8e605369b4ad74.png)](https://www.instagram.com/softuni_org)[![Software University @ Twitter](RackMultipart20240418-1-rz3zmt_html_ff9c629b0a21eb6b.png)](https://twitter.com/SoftUni1)[![Software University @ YouTube](RackMultipart20240418-1-rz3zmt_html_7db86a748da0e575.png)](https://www.youtube.com/channel/UCqvOk8tYzfRS-eDy4vs3UyA)[![](RackMultipart20240418-1-rz3zmt_html_95554caa563bbdb3.png)](https://www.linkedin.com/company/softuni/)[![](RackMultipart20240418-1-rz3zmt_html_4df51bfadcab813.png)](https://github.com/SoftUni)[![Software University: Email Us](RackMultipart20240418-1-rz3zmt_html_d7fa82ab7332f3fa.png)](mailto:info@softuni.org)

Page 3 of 3