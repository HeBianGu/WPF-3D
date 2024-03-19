using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkNumberToString
	/// </summary>
	/// <remarks>
	///  Convert floating and fixed point numbers to strings
	///
	/// This class uses the double-conversion library to convert float and double
	/// numbers to std::string without numerical precision errors.
	/// It is possible to specify the low and high exponent where the string representation
	/// will switch to scientific notation instead of fixed point notation.
	///
	/// For other types, this class rely on std::to_string.
	///
	/// Typical use:
	///
	/// @code{cpp}
	///  #include "vtkNumberToString.h"
	///  float a = 1.0f/3.0f;
	///  vtkNumberToString converter;
	///  std::cout &lt;&lt; converter.Convert(a) &lt;&lt; std::endl;
	/// @endcode
	///
	/// @code{cpp}
	///  #include "vtkNumberToString.h"
	///  double a = 1e7*vtkMath::PI();
	///  vtkNumberToString converter;
	///  converter.SetLowExponent(-6);
	///  converter.SetHighExponent(6);
	///  std::cout &lt;&lt; converter.Convert(a) &lt;&lt; std::endl;
	/// @endcode
	///
	/// </remarks>
	// Token: 0x02000731 RID: 1841
	public class vtkNumberToString : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013346 RID: 78662 RVA: 0x001B2847 File Offset: 0x001B0A47
		static vtkNumberToString()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNumberToString.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNumberToString"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013347 RID: 78663 RVA: 0x001B286F File Offset: 0x001B0A6F
		public vtkNumberToString(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013348 RID: 78664 RVA: 0x001B287D File Offset: 0x001B0A7D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013349 RID: 78665
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNumberToString_Convert_01(HandleRef pThis, double val);

		/// <summary>
		/// Convert a number to an accurate string representation of that number.
		/// A templated generic implementation is provided, which rely on std::to_string for types
		/// other than double or float.
		/// </summary>
		// Token: 0x0601334A RID: 78666 RVA: 0x001B2888 File Offset: 0x001B0A88
		public string Convert(double val)
		{
			return vtkNumberToString.vtkNumberToString_Convert_01(base.GetCppThis(), val);
		}

		// Token: 0x0601334B RID: 78667
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNumberToString_Convert_02(HandleRef pThis, float val);

		/// <summary>
		/// Convert a number to an accurate string representation of that number.
		/// A templated generic implementation is provided, which rely on std::to_string for types
		/// other than double or float.
		/// </summary>
		// Token: 0x0601334C RID: 78668 RVA: 0x001B28A8 File Offset: 0x001B0AA8
		public string Convert(float val)
		{
			return vtkNumberToString.vtkNumberToString_Convert_02(base.GetCppThis(), val);
		}

		// Token: 0x0601334D RID: 78669
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNumberToString_GetHighExponent_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the HighExponent for string conversion.
		/// HighExponent correspond to the highest exponent value that
		/// will use fixed point notation in the returned string instead of a scientific notation.
		/// HighExponent = 6, 1e6 -&gt; "1000000"
		/// HighExponent = 5, 1e6 -&gt; "1e6"
		/// </summary>
		// Token: 0x0601334E RID: 78670 RVA: 0x001B28C8 File Offset: 0x001B0AC8
		public int GetHighExponent()
		{
			return vtkNumberToString.vtkNumberToString_GetHighExponent_03(base.GetCppThis());
		}

		// Token: 0x0601334F RID: 78671
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNumberToString_GetLowExponent_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the LowExponent for string conversion.
		/// It correspond to the closest to zero exponent value that
		/// will use fixed point notation in the returned string instead of a scientific notation.
		/// eg:
		/// LowExponent = 6, 1e-6 -&gt; "0.000001"
		/// LowExponent = 5, 1e-6 -&gt; "1e-6"
		/// </summary>
		// Token: 0x06013350 RID: 78672 RVA: 0x001B28E8 File Offset: 0x001B0AE8
		public int GetLowExponent()
		{
			return vtkNumberToString.vtkNumberToString_GetLowExponent_04(base.GetCppThis());
		}

		// Token: 0x06013351 RID: 78673
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNumberToString_SetHighExponent_05(HandleRef pThis, int highExponent);

		/// <summary>
		/// Set/Get the HighExponent for string conversion.
		/// HighExponent correspond to the highest exponent value that
		/// will use fixed point notation in the returned string instead of a scientific notation.
		/// HighExponent = 6, 1e6 -&gt; "1000000"
		/// HighExponent = 5, 1e6 -&gt; "1e6"
		/// </summary>
		// Token: 0x06013352 RID: 78674 RVA: 0x001B2907 File Offset: 0x001B0B07
		public void SetHighExponent(int highExponent)
		{
			vtkNumberToString.vtkNumberToString_SetHighExponent_05(base.GetCppThis(), highExponent);
		}

		// Token: 0x06013353 RID: 78675
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNumberToString_SetLowExponent_06(HandleRef pThis, int lowExponent);

		/// <summary>
		/// Set/Get the LowExponent for string conversion.
		/// It correspond to the closest to zero exponent value that
		/// will use fixed point notation in the returned string instead of a scientific notation.
		/// eg:
		/// LowExponent = 6, 1e-6 -&gt; "0.000001"
		/// LowExponent = 5, 1e-6 -&gt; "1e-6"
		/// </summary>
		// Token: 0x06013354 RID: 78676 RVA: 0x001B2917 File Offset: 0x001B0B17
		public void SetLowExponent(int lowExponent)
		{
			vtkNumberToString.vtkNumberToString_SetLowExponent_06(base.GetCppThis(), lowExponent);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001630 RID: 5680
		public new const string MRFullTypeName = "Kitware.VTK.vtkNumberToString";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001631 RID: 5681
		public new static readonly string MRClassNameKey = "class vtkNumberToString";
	}
}
