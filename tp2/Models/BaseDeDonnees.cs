﻿namespace tp2.Models;

public class BaseDeDonnees
{
    public List<CodeEditor> CodeEditors { get; }

    public BaseDeDonnees()
    {
        CodeEditors = new List<CodeEditor>
        {
            new CodeEditor
            {
                Name = "Visual Studio",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs, as well as websites, web apps, web services and mobile apps. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code. C++, C#, Visual Basic, F#, JavaScript, TypeScript and Python are the programming languages supported by Visual Studio.",
                Id = 1,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "IntelliJ IDEA",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "IntelliJ IDEA is an integrated development environment (IDE) written in Java for developing computer software. The name IntelliJ IDEA stands for Integrated Development Environment. It is developed by JetBrains (formerly known as IntelliJ), and is available as an Apache 2 Licensed community edition, and in a proprietary commercial edition. IntelliJ IDEA provides first-class support for Java, Scala, Groovy and other JVM-based languages. It also provides support for JavaScript, TypeScript, CoffeeScript, CSS, HTML, XML, SQL, and many other languages through plugins.",
                Id = 2,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Webstorm",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "WebStorm is a cross-platform integrated development environment (IDE) developed by JetBrains for web development. It was created from IntelliJ IDEA, which was originally developed for Java development. WebStorm provides code completion, on-the-fly error detection, and integrated unit testing. It also supports version control systems such as Git, Mercurial, and Subversion. WebStorm supports JavaScript, TypeScript, CoffeeScript, CSS, HTML, XML, JSON, and many other languages through plugins.",
                Id = 3,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Sublime Text",
                EditorCategory = EditorCategory.TextEditor,
                Description =
                    "Sublime Text is a proprietary cross-platform source code editor with a Python application programming interface (API). Sublime Text uses a custom GUI toolkit, optimized for speed and beauty, while taking advantage of native functionality on each platform. Sublime Text supports many programming languages and markup languages, and functions can be added by users with plugins, typically community-built and maintained under free-software licenses.",
                Id = 4,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Rider",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "Rider is a cross-platform .NET IDE developed by JetBrains. It is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux.",
                Id = 5,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "CLion",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux.",
                Id = 6,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Powershell ISE",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "The PowerShell Integrated Scripting Environment (ISE) is a graphical scripting environment for Windows PowerShell. It is a Windows application that provides a graphical user interface (GUI) for creating and debugging scripts. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008.",
                Id = 7,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Nano",
                EditorCategory = EditorCategory.Terminal,
                Description =
                    "Nano is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Nano is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Nano is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Nano is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client.",
                Id = 8,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Emacs",
                EditorCategory = EditorCategory.Terminal,
                Description =
                    "GNU Emacs is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. GNU Emacs is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. GNU Emacs is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. GNU Emacs is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client.",
                Id = 9,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "Vim",
                EditorCategory = EditorCategory.Terminal,
                Description =
                    "Vim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Vim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Vim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. Vim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client.",
                Id = 10,
                Favorite = false
            },
            new CodeEditor
            {
                Name = "NeoVim",
                EditorCategory = EditorCategory.Terminal,
                Description =
                    "NeoVim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. NeoVim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. NeoVim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client. NeoVim is a free and open-source text editor and a command-line utility for Unix-like operating systems. It was originally designed to be a clone of Pico, the default text editor in the Pine email client.",
                Id = 11,
                Favorite = false
            },
            new CodeEditor()
            {
                Name = "Visual Studio Code",
                Description = "Visual Studio Code is a source code editor developed by Microsoft for Windows, Linux and macOS. Features include support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git.",
                EditorCategory = EditorCategory.IDE,
                Id = 12,
                Favorite = false
            }
        };
    }
}