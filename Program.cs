// See https://aka.ms/new-console-template for more information
using project_echallenge;

Console.WriteLine("Hello, World!");

var features = new c_11();

// Call all methods to test C# 11 features
features.RawStringLiterals();
features.ListPatterns();
features.TestGenericMath();
features.GenericAttributes();
features.UTF8StringLiterals();
features.NewlineStringInterpolation();
features.FileLocalTypes();
features.RequiredMembers();
features.AutoDefaultStructs();
features.PatternMatchSpan();
features.ExtendedNameofScope();
features.NumericIntPtr();
features.RefScoped();
features.MethodGroupConversion();



var features12 = new C_12();

// Call each test method separately
Console.WriteLine("\n=== Primary Constructor ===");
features12.TestPrimaryConstructor();

Console.WriteLine("\n=== Collection Expressions ===");
features12.TestCollectionExpressions();

Console.WriteLine("\n=== Inline Arrays ===");
features12.TestInlineArrays();

Console.WriteLine("\n=== Optional Parameters in Lambda ===");
features12.TestOptionalParametersLambda();

Console.WriteLine("\n=== ref readonly Parameters ===");
features12.TestRefReadonlyParameters();

Console.WriteLine("\n=== Alias Any Type ===");
features12.TestAliasAnyType();

//Console.WriteLine("\n=== Experimental Feature ===");
//features12.TestExperimentalFeature();

//Console.WriteLine("\n=== Interceptors (Preview) ===");
//features12.TestInterceptors();

Console.WriteLine("\n✅ All C# 12 features tested individually!");