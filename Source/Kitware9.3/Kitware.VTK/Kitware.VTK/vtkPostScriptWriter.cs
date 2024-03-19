using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPostScriptWriter
	/// </summary>
	/// <remarks>
	///    Writes an image as a PostScript file.
	///
	/// vtkPostScriptWriter writes an image as a PostScript file using some
	/// reasonable scalings and centered on the page which is assumed to be
	/// about 8.5 by 11 inches. This is based loosely off of the code from
	/// pnmtops.c. Right now there aren't any real options.
	/// </remarks>
	// Token: 0x020007A0 RID: 1952
	public class vtkPostScriptWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014090 RID: 82064 RVA: 0x001C4EA3 File Offset: 0x001C30A3
		static vtkPostScriptWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPostScriptWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPostScriptWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014091 RID: 82065 RVA: 0x001C4ECB File Offset: 0x001C30CB
		public vtkPostScriptWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014092 RID: 82066
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPostScriptWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014093 RID: 82067 RVA: 0x001C4EDC File Offset: 0x001C30DC
		public new static vtkPostScriptWriter New()
		{
			vtkPostScriptWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPostScriptWriter.vtkPostScriptWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPostScriptWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014094 RID: 82068 RVA: 0x001C4F30 File Offset: 0x001C3130
		public vtkPostScriptWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPostScriptWriter.vtkPostScriptWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014095 RID: 82069 RVA: 0x001C4F74 File Offset: 0x001C3174
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014096 RID: 82070
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPostScriptWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014097 RID: 82071 RVA: 0x001C4F80 File Offset: 0x001C3180
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPostScriptWriter.vtkPostScriptWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06014098 RID: 82072
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPostScriptWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014099 RID: 82073 RVA: 0x001C4FA0 File Offset: 0x001C31A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPostScriptWriter.vtkPostScriptWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601409A RID: 82074
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPostScriptWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601409B RID: 82075 RVA: 0x001C4FBC File Offset: 0x001C31BC
		public override int IsA(string type)
		{
			return vtkPostScriptWriter.vtkPostScriptWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601409C RID: 82076
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPostScriptWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601409D RID: 82077 RVA: 0x001C4FDC File Offset: 0x001C31DC
		public new static int IsTypeOf(string type)
		{
			return vtkPostScriptWriter.vtkPostScriptWriter_IsTypeOf_04(type);
		}

		// Token: 0x0601409E RID: 82078
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPostScriptWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601409F RID: 82079 RVA: 0x001C4FF8 File Offset: 0x001C31F8
		public new vtkPostScriptWriter NewInstance()
		{
			vtkPostScriptWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPostScriptWriter.vtkPostScriptWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPostScriptWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060140A0 RID: 82080
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPostScriptWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060140A1 RID: 82081 RVA: 0x001C5054 File Offset: 0x001C3254
		public new static vtkPostScriptWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPostScriptWriter vtkPostScriptWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPostScriptWriter.vtkPostScriptWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPostScriptWriter = (vtkPostScriptWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPostScriptWriter.Register(null);
				}
			}
			return vtkPostScriptWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001740 RID: 5952
		public new const string MRFullTypeName = "Kitware.VTK.vtkPostScriptWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001741 RID: 5953
		public new static readonly string MRClassNameKey = "class vtkPostScriptWriter";
	}
}
