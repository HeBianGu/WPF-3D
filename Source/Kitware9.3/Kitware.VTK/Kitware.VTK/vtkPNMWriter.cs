using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPNMWriter
	/// </summary>
	/// <remarks>
	///    Writes PNM (portable any map)  files.
	///
	/// vtkPNMWriter writes PNM file. The data type
	/// of the file is unsigned char regardless of the input type.
	/// </remarks>
	// Token: 0x0200079F RID: 1951
	public class vtkPNMWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601407E RID: 82046 RVA: 0x001C4C73 File Offset: 0x001C2E73
		static vtkPNMWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNMWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNMWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601407F RID: 82047 RVA: 0x001C4C9B File Offset: 0x001C2E9B
		public vtkPNMWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014080 RID: 82048
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014081 RID: 82049 RVA: 0x001C4CAC File Offset: 0x001C2EAC
		public new static vtkPNMWriter New()
		{
			vtkPNMWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMWriter.vtkPNMWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014082 RID: 82050 RVA: 0x001C4D00 File Offset: 0x001C2F00
		public vtkPNMWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPNMWriter.vtkPNMWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014083 RID: 82051 RVA: 0x001C4D44 File Offset: 0x001C2F44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014084 RID: 82052
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNMWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014085 RID: 82053 RVA: 0x001C4D50 File Offset: 0x001C2F50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPNMWriter.vtkPNMWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06014086 RID: 82054
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNMWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014087 RID: 82055 RVA: 0x001C4D70 File Offset: 0x001C2F70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPNMWriter.vtkPNMWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06014088 RID: 82056
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNMWriter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014089 RID: 82057 RVA: 0x001C4D8C File Offset: 0x001C2F8C
		public override int IsA(string type)
		{
			return vtkPNMWriter.vtkPNMWriter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601408A RID: 82058
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNMWriter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601408B RID: 82059 RVA: 0x001C4DAC File Offset: 0x001C2FAC
		public new static int IsTypeOf(string type)
		{
			return vtkPNMWriter.vtkPNMWriter_IsTypeOf_04(type);
		}

		// Token: 0x0601408C RID: 82060
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601408D RID: 82061 RVA: 0x001C4DC8 File Offset: 0x001C2FC8
		public new vtkPNMWriter NewInstance()
		{
			vtkPNMWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMWriter.vtkPNMWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601408E RID: 82062
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNMWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601408F RID: 82063 RVA: 0x001C4E24 File Offset: 0x001C3024
		public new static vtkPNMWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPNMWriter vtkPNMWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNMWriter.vtkPNMWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNMWriter = (vtkPNMWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNMWriter.Register(null);
				}
			}
			return vtkPNMWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173E RID: 5950
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNMWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173F RID: 5951
		public new static readonly string MRClassNameKey = "class vtkPNMWriter";
	}
}
