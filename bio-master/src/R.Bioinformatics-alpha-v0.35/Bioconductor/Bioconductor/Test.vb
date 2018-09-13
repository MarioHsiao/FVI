﻿Imports RDotNET.Extensions.Bioinformatics
Imports RDotNET.Extensions.VisualBasic
Imports RDotNET.Extensions.VisualBasic.gplots
Imports RDotNET.Extensions.VisualBasic.grDevices
Imports RDotNET.Extensions.VisualBasic.utils.read.table
Imports SMRUCC.R.CRAN.Bioconductor.Web

Imports Microsoft.VisualBasic.Serialization
Imports SMRUCC.R.CRAN.Bioconductor.Web.Packages
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ComponentModel.DataStructures
Imports Microsoft.VisualBasic.ComponentModel.DataStructures.BinaryTree
Imports Microsoft.VisualBasic
Imports System.Text

Imports PhyloNode = Microsoft.VisualBasic.ComponentModel.DataStructures.BinaryTree.TreeNode(Of Integer)

Imports RegExp = System.Text.RegularExpressions.Regex
Imports MatchResult = System.Text.RegularExpressions.MatchCollection

Imports Node = System.Xml.XmlNode
Imports Element = System.Xml.XmlElement
Imports NodeList = System.Xml.XmlNodeList

Imports Microsoft.VisualBasic.Linq


Module Test

    Dim heatmap As String = <R>

                                library(RColorBrewer)

df &lt;- read.csv(file="F:\\1.13.RegPrecise_network\\FBA\\xcam314565\\19.0\\data\\metabolic-reactions.rFBA\\heatmap\\objfunc-30__scales.csv", 
header=TRUE, 
sep=",", 
quote="\"", 
dec=".", 
fill=TRUE, 
comment.char="")
row.names(df) &lt;- df$Locus
df &lt;- df[,-1]
df &lt;- data.matrix(df)

library(gplots)

tiff(compression=c("none", "rle", "lzw", "jpeg", "zip", "lzw+p", "zip+p"), 
filename="F:/1.13.RegPrecise_network/FBA/xcam314565/19.0/data/metabolic-reactions.rFBA/heatmap/objfunc-30__scales.tiff", 
width=4000, 
height=3200, 
units="px", 
pointsize=12, 
bg="white", 
res=NA, 
family="", 
restoreConsole=TRUE, 
type=c("windows", "cairo"))

result &lt;- heatmap.2(df, col=redgreen(75), scale="row",   margin=c(15,15)  ,    key=TRUE, symkey=FALSE, density.info="none", trace="none", cexRow=2,cexCol=2)
dev.off()




                            </R>

    Sub Main()


        Dim vv As New VennDiagram.vennDiagramPlot







        Dim hm As New Heatmap With {
            .dataset = New readcsv("E:\R.Bioinformatics\datasets\ppg2008.csv"),
            .heatmap = heatmap2.Puriney,
            .image = New tiff("x:/ffff.tiff", 8000, 6500)
        }

        Dim r As String = hm.RScript

        Call r.SaveTo("x:\dddd.r")
        '     Call RSystem.REngine.WriteLine(r)

        Dim resultooo = heatmap2OUT.RParser(hm.output)
        resultooo.locus = hm.locusId
        resultooo.samples = hm.samples


        Call resultooo.GetJson.SaveTo("x:\heatmap.2.sample.json")



        Dim xx As Pointer = 5

        Dim ndd As Integer = +xx

        Dim xxsss = +ndd


        Dim ddd As String() = LoadJsonFile(Of String())("E:\R.Bioinformatics\datasets\heatmap_testOUT.json")


        Dim hhhhh = heatmap2OUT.RParser(ddd)

        Call hhhhh.GetJson.SaveTo("x:\ddd.json")

        '    Call RSystem.REngine.WriteLine(Test.heatmap)

        '    Dim result = RSystem.REngine.WriteLine("result")

        '   Call result.GetJson.SaveTo("E:\R.Bioinformatics\datasets\heatmap_testOUT.json")








        Dim rp = Web.Repository.LoadDefault
        Dim pp = rp.softwares.First
        pp.GetDetails("E:\R.Bioinformatics\Bioconductor\ParserTest.html".ReadAllText)
    End Sub

End Module
