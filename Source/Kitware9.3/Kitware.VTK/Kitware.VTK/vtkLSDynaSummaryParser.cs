using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLSDynaSummaryParser
	/// </summary>
	/// <remarks>
	///    This is a helper class used by vtkLSDynaReader to read XML files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLSDynaReader
	/// </seealso>
	// Token: 0x02000183 RID: 387
	public class vtkLSDynaSummaryParser : vtkXMLParser
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004A8C RID: 19084 RVA: 0x0006C81B File Offset: 0x0006AA1B
		static vtkLSDynaSummaryParser()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLSDynaSummaryParser.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLSDynaSummaryParser"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004A8D RID: 19085 RVA: 0x0006C843 File Offset: 0x0006AA43
		public vtkLSDynaSummaryParser(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004A8E RID: 19086
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaSummaryParser_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A8F RID: 19087 RVA: 0x0006C854 File Offset: 0x0006AA54
		public new static vtkLSDynaSummaryParser New()
		{
			vtkLSDynaSummaryParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaSummaryParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A90 RID: 19088 RVA: 0x0006C8A8 File Offset: 0x0006AAA8
		public vtkLSDynaSummaryParser() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004A91 RID: 19089 RVA: 0x0006C8EC File Offset: 0x0006AAEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004A92 RID: 19090
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaSummaryParser_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A93 RID: 19091 RVA: 0x0006C8F8 File Offset: 0x0006AAF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06004A94 RID: 19092
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaSummaryParser_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A95 RID: 19093 RVA: 0x0006C918 File Offset: 0x0006AB18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06004A96 RID: 19094
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaSummaryParser_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A97 RID: 19095 RVA: 0x0006C934 File Offset: 0x0006AB34
		public override int IsA(string type)
		{
			return vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06004A98 RID: 19096
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaSummaryParser_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A99 RID: 19097 RVA: 0x0006C954 File Offset: 0x0006AB54
		public new static int IsTypeOf(string type)
		{
			return vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_IsTypeOf_04(type);
		}

		// Token: 0x06004A9A RID: 19098
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaSummaryParser_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A9B RID: 19099 RVA: 0x0006C970 File Offset: 0x0006AB70
		public new vtkLSDynaSummaryParser NewInstance()
		{
			vtkLSDynaSummaryParser result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaSummaryParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004A9C RID: 19100
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaSummaryParser_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A9D RID: 19101 RVA: 0x0006C9CC File Offset: 0x0006ABCC
		public new static vtkLSDynaSummaryParser SafeDownCast(vtkObjectBase o)
		{
			vtkLSDynaSummaryParser vtkLSDynaSummaryParser = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaSummaryParser.vtkLSDynaSummaryParser_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLSDynaSummaryParser = (vtkLSDynaSummaryParser)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLSDynaSummaryParser.Register(null);
				}
			}
			return vtkLSDynaSummaryParser;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000757 RID: 1879
		public new const string MRFullTypeName = "Kitware.VTK.vtkLSDynaSummaryParser";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000758 RID: 1880
		public new static readonly string MRClassNameKey = "class vtkLSDynaSummaryParser";
	}
}
