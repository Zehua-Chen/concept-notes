\NeedsTeXFormat{LaTeX2e}
\ProvidesClass{note}

\LoadClass[letterpaper, 12pt]{article}

%Remove paragraph indentations
\setlength{\parindent}{0pt}

%Fonts
% - Math font: Times New Roman
\RequirePackage{newtxmath}
% - Text Font: Helvetica
\RequirePackage[scaled=0.92]{helvet}
\renewcommand{\familydefault}{\sfdefault}

%Enable highlighter support
% - use \hl{text}
\RequirePackage{color, soul}

%For Advanced Math Support

%Math Symbols
\RequirePackage{amssymb}
%Math Environments
\RequirePackage{amsmath}

%Add book marks and hyper links
\RequirePackage{hyperref}
\RequirePackage{bookmark}

%Adjust the paper margin to be uniform with that in Microsoft Word
\RequirePackage[twoside, inner=3cm, outer=2cm, top=2cm, bottom=2cm]{geometry}

%Make Headers and Footers
\RequirePackage{fancyhdr}
\pagestyle{fancy}
% - Get rid of header borders
\def\headrulewidth{0pt}
% - Place date on the rigth header
\rhead{\@date}
% - Place subject on the left header
% - - Provided Command: \subject{text}
\newcommand{\subject}[1]{\lhead{#1}}
% - Place document id on the center header
% - - Provided Command: \id{number}
\newcommand{\id}[1]{\chead{#1}}

%This line is to make the page count Helvetica
\cfoot{\sffamily\thepage}

%Customize Headings
% - Remove Section Numberings
\RequirePackage{titlesec}
\titleformat{\section}[hang]{\Large\bfseries}{}{0pt}{}{}
\titleformat{\subsection}[hang]{\large\bfseries}{}{0pt}{}{}
\titleformat{\subsubsection}[hang]{\bfseries}{}{0pt}{}{}

% Customize \hrulefill's thickness to 1pt, used in drawing the line below title
\def\hrulefill{\leavevmode\leaders\hrule height 1pt\hfill\kern\z@}

%Print titles and document infos
% Arg #1 - Unit of the note
\newenvironment{note}[1]{
    \begin{flushleft}
        % Bold & Large title
        \noindent{\huge\textbf{\@title}}\\
        %Draw line
        \noindent\hrulefill\\
        %Leave space: 5pt
        \vspace{5pt}
        %Write the unit of the note
        \noindent{\LARGE#1} \\
    \end{flushleft}
    \tableofcontents
    
}{}