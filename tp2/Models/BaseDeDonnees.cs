namespace tp2.Models;

/// <summary>
/// Fausse base de données d'éditeurs de code
/// </summary>
public class BaseDeDonnees
{
    
    /// <summary>
    /// Liste des éditeurs de code
    /// </summary>
    public List<CodeEditor> CodeEditors { get; }

    /// <summary>
    /// Constructeur de la base de données
    /// </summary>
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
                Favorite = false,
                PersonalRating = 2
            },
            new CodeEditor
            {
                Name = "IntelliJ IDEA",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "IntelliJ IDEA is an integrated development environment (IDE) written in Java for developing computer software. The name IntelliJ IDEA stands for Integrated Development Environment. It is developed by JetBrains (formerly known as IntelliJ), and is available as an Apache 2 Licensed community edition, and in a proprietary commercial edition. IntelliJ IDEA provides first-class support for Java, Scala, Groovy and other JVM-based languages. It also provides support for JavaScript, TypeScript, CoffeeScript, CSS, HTML, XML, SQL, and many other languages through plugins.",
                Id = 2,
                Favorite = false,
                PersonalRating = 10
            },
            new CodeEditor
            {
                Name = "Webstorm",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "WebStorm is a cross-platform integrated development environment (IDE) developed by JetBrains for web development. It was created from IntelliJ IDEA, which was originally developed for Java development. WebStorm provides code completion, on-the-fly error detection, and integrated unit testing. It also supports version control systems such as Git, Mercurial, and Subversion. WebStorm supports JavaScript, TypeScript, CoffeeScript, CSS, HTML, XML, JSON, and many other languages through plugins.",
                Id = 3,
                Favorite = false,
                PersonalRating = 9
            },
            new CodeEditor
            {
                Name = "Sublime Text",
                EditorCategory = EditorCategory.TextEditor,
                Description =
                    "Sublime Text is a proprietary cross-platform source code editor with a Python application programming interface (API). Sublime Text uses a custom GUI toolkit, optimized for speed and beauty, while taking advantage of native functionality on each platform. Sublime Text supports many programming languages and markup languages, and functions can be added by users with plugins, typically community-built and maintained under free-software licenses.",
                Id = 4,
                Favorite = false,
                PersonalRating = 8
            },
            new CodeEditor
            {
                Name = "Rider",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "Rider is a cross-platform .NET IDE developed by JetBrains. It is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux. Rider is a cross-platform .NET IDE based on the IntelliJ Platform. It is available for Windows, macOS and Linux.",
                Id = 5,
                Favorite = false,
                PersonalRating = 10
            },
            new CodeEditor
            {
                Name = "CLion",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux. CLion is a cross-platform integrated development environment (IDE) for C and C++ developed by JetBrains. It is available for Windows, macOS and Linux.",
                Id = 6,
                Favorite = false,
                PersonalRating = 10
            },
            new CodeEditor
            {
                Name = "Powershell ISE",
                EditorCategory = EditorCategory.IDE,
                Description =
                    "The PowerShell Integrated Scripting Environment (ISE) is a graphical scripting environment for Windows PowerShell. It is a Windows application that provides a graphical user interface (GUI) for creating and debugging scripts. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008. The ISE is included with Windows 7 and Windows Server 2008 R2, and is available as a free download for Windows Vista and Windows Server 2008.",
                Id = 7,
                Favorite = false,
                PersonalRating = 4
            },
            new CodeEditor
            {
                Name = "Nano",
                EditorCategory = EditorCategory.Terminal,
                Description =
                    "GNU nano is a text editor for Unix-like computing systems or operating environments using a command line interface. It emulates the Pico text editor, part of the Pine email client, and also provides additional functionality. Unlike Pico, nano is licensed under the GNU General Public License (GPL). Released as free software by Chris Allegretta in 1999, nano became part of the GNU Project in 2001. The logo resembles the lowercase form of the Greek letter Eta (η).",
                Id = 8,
                Favorite = false,
                PersonalRating = 3
            },
            new CodeEditor
            {
                Name = "Emacs",
                EditorCategory = EditorCategory.Terminal,
                Description = "Emacs, originally named EMACS (an acronym for \"Editor MACroS\"), is a family of text editors that are characterized by their extensibility. The manual for the most widely used variant, GNU Emacs, describes it as \"the extensible, customizable, self-documenting, real-time display editor\". Development of the first Emacs began in the mid-1970s, and work on its direct descendant, GNU Emacs, continues actively; the latest version is 28.2, released in September 2022. Emacs has over 10,000 built-in commands and its user interface allows the user to combine these commands into macros to automate work. Implementations of Emacs typically feature a dialect of the Lisp programming language, allowing users and developers to write new commands and applications for the editor. Extensions have been written to, among other things, manage files, remote access, e-mail, outlines, multimedia, git integration, and RSS feeds, as well as implementations of ELIZA, Pong, Conway's Life, Snake, Dunnet, and Tetris. The original EMACS was written in 1976 by David A. Moon and Guy L. Steele Jr. as a set of Editor MACroS for the TECO editor. It was inspired by the ideas of the TECO-macro editors TECMAC and TMACS. The most popular, and most ported, version of Emacs is GNU Emacs, which was created by Richard Stallman for the GNU Project. XEmacs is a variant that branched from GNU Emacs in 1991. GNU Emacs and XEmacs use similar Lisp dialects and are, for the most part, compatible with each other. XEmacs development is inactive. Emacs is, along with vi, one of the two main contenders in the traditional editor wars of Unix culture. Emacs is among the oldest free and open source projects still under development.",
                Id = 9,
                Favorite = false,
                PersonalRating = 6
            },
            new CodeEditor
            {
                Name = "Vim",
                EditorCategory = EditorCategory.Terminal,
                Description = "Vim (a contraction of Vi IMproved) is a free and open-source, screen-based text editor program. It is an improved clone of Bill Joy's vi. Vim's author, Bram Moolenaar, derived Vim from a port of the Stevie editor for Amiga and released a version to the public in 1991. Vim is designed for use both from a command-line interface and as a standalone application in a graphical user interface. Since its release for the Amiga, cross-platform development has made it available on many other systems. In 2006, it was voted the most popular editor amongst Linux Journal readers;[8] in 2015 the Stack Overflow developer survey found it to be the third most popular text editor, and in 2019 the fifth most popular development environment.",
                Id = 10,
                Favorite = false,
                PersonalRating = 5
            },
            new CodeEditor
            {
                Name = "NeoVim",
                EditorCategory = EditorCategory.Terminal,
                Description = "Neovim is a project that seeks to aggressively refactor Vim in order to Simplify maintenance and encourage contributions, Split the work between multiple developers, Enable advanced UIs without modifications to the core and to Maximize extensibility.",
                Id = 11,
                Favorite = false,
                PersonalRating = 7
            },
            new CodeEditor()
            {
                Name = "Visual Studio Code",
                Description = "Visual Studio Code is a source code editor developed by Microsoft for Windows, Linux and macOS. Features include support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git. It includes support for debugging, syntax highlighting, intelligent code completion, snippets, code refactoring, and embedded Git.",
                EditorCategory = EditorCategory.TextEditor,
                Id = 12,
                Favorite = false,
                PersonalRating = 10
            }
        };
    }
}