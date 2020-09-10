﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace RenderProject
{
    public class EntryPoint
    {
        public void FromVegas(Vegas myVegas)
        {
            String inputFilePath = "F:\\videos\\vlogs\\15 - Live API 3\\projet.veg";
            if (myVegas.OpenProject(inputFilePath))
            {
                foreach (Renderer renderer in myVegas.Renderers)
                {
                    String rendererName = renderer.FileTypeName;

                    if (rendererName == "Windows Media Video V11")
                    {
                        foreach (RenderTemplate template in renderer.Templates)
                        {
                            
                        }
                    }
                    MessageBox.Show(rendererName);
                }
                /*
            RenderArgs renderArgs = new RenderArgs(myVegas.Project);
            RenderTemplate renderTemplate = new RenderTemplate();
            renderArgs.RenderTemplate = renderTemplate;
            String outputFilePath = "F:\\videos\\vlogs\\15 - Live API 3\\projet.veg";
            renderArgs.OutputFile = outputFilePath;
            RenderStatus renderStatus = myVegas.Render(renderArgs); */
            }
            else
            {
                myVegas.Exit();
            }
        }
    }
}

