using System.CommandLine;
using System.IO;
using System.Threading.Tasks;

namespace demonDATA {
    internal class Program {
        static async Task<int> Main(string[] args) {
            var fileArgument = new Argument<FileInfo>(
                name: "file",
                description: "The file to extract");

            var root = new RootCommand("A tool to extract data from files on 3DS roms and/or ATLUS games." +
                                       "\n This tool is part of the demonENGINE project." +
                                       "\n\n Supported file extensions: .bin (atlus), .bcmdl, .bcskla, .bcskle, .ctpk, .icn, .moflex, .bcstm, .bcsar, .bcsdr, .shbin" +
                                       "\n Currently implemented file extensions: .bcmdl"); 
            root.AddArgument(fileArgument);
            root.SetHandler(CommandHandler.handleExtract, fileArgument);
            return await root.InvokeAsync(args);
        }
    }
}