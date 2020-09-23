# Sound parameters evaluation
![Interface](/docs/FrequencyAnalysis/images/12spectrogramMy.png)

## Purpose
Project created for classes in Sound Analysis and Processing at Warsaw University of Technology

Program allows to load the audio file, analyse it and display some major parameters. Sound analysis has been implemented in three different areas:
- Evalutaion of time domain parameters (both frame and clip level)
- Evalutaion of frequenct domain parameters (both frame and clip level)
- Frequency analysis

All the topics are covered by separate reports (written in Polish). All of them are implemented in one project.

## Technology
Project is created using .NET Framework, with presentation layer based on Windows Forms. 

The only implemented language version is English (except for docs written in Polish, can be found in subdirectory _/docs_).

## Dependencies
In order to simplify the project, some external libraries are used:
- _NAudio_ - optimize loading and parsing audio files (supported _*.wav_ and _*.mp3_)
- _MathNet.Numerics_ - implementation of Fast Fourier Transform and window functions
- _Oxyplot_ - plots/charts 
