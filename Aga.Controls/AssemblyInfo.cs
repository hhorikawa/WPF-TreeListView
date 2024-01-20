
using System.Runtime.CompilerServices;
using System.Windows;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,            //where theme specific resource dictionaries are located
                                                //(used if a resource is not found in the page,
                                                // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly   //where the generic resource dictionary is located
                                                //(used if a resource is not found in the page,
                                                // app, or any theme specific resource dictionaries)
)]

// プロジェクトを跨ぐ UnitTests で internal class にアクセスできないエラーが出
// るのを回避.
[assembly: InternalsVisibleTo("UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100d38e92f544ec55348a59865691be10df252e1e66a18a0260fdcae90866d35e135a0ba34b7c06ee93f56a7eac77cdefce7a10610e4d21d3cd83037b169cc9988e5995efbdb39ccfc42cbe6e0dbde648cb4c27d92742bda0bb293ab924b35d6c2d314d1dee9e8b7752e8aeb0ff27e6bc60817556e650f7b0d8a9e84a155fbd64ab")]
