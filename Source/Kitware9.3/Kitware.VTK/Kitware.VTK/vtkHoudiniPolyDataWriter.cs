using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHoudiniPolyDataWriter
	/// </summary>
	/// <remarks>
	///    write vtk polygonal data to Houdini file.
	///
	///
	/// vtkHoudiniPolyDataWriter is a source object that writes VTK polygonal data
	/// files in ASCII Houdini format (see
	/// http://www.sidefx.com/docs/houdini15.0/io/formats/geo).
	/// </remarks>
	// Token: 0x02000206 RID: 518
	public class vtkHoudiniPolyDataWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600633E RID: 25406 RVA: 0x0008EC2F File Offset: 0x0008CE2F
		static vtkHoudiniPolyDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHoudiniPolyDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHoudiniPolyDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600633F RID: 25407 RVA: 0x0008EC57 File Offset: 0x0008CE57
		public vtkHoudiniPolyDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006340 RID: 25408
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoudiniPolyDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006341 RID: 25409 RVA: 0x0008EC68 File Offset: 0x0008CE68
		public new static vtkHoudiniPolyDataWriter New()
		{
			vtkHoudiniPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoudiniPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006342 RID: 25410 RVA: 0x0008ECBC File Offset: 0x0008CEBC
		public vtkHoudiniPolyDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006343 RID: 25411 RVA: 0x0008ED00 File Offset: 0x0008CF00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006344 RID: 25412
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoudiniPolyDataWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x06006345 RID: 25413 RVA: 0x0008ED0C File Offset: 0x0008CF0C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006346 RID: 25414
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHoudiniPolyDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006347 RID: 25415 RVA: 0x0008ED48 File Offset: 0x0008CF48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006348 RID: 25416
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHoudiniPolyDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006349 RID: 25417 RVA: 0x0008ED68 File Offset: 0x0008CF68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600634A RID: 25418
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoudiniPolyDataWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600634B RID: 25419 RVA: 0x0008ED84 File Offset: 0x0008CF84
		public override int IsA(string type)
		{
			return vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600634C RID: 25420
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHoudiniPolyDataWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600634D RID: 25421 RVA: 0x0008EDA4 File Offset: 0x0008CFA4
		public new static int IsTypeOf(string type)
		{
			return vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_IsTypeOf_05(type);
		}

		// Token: 0x0600634E RID: 25422
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoudiniPolyDataWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600634F RID: 25423 RVA: 0x0008EDC0 File Offset: 0x0008CFC0
		public new vtkHoudiniPolyDataWriter NewInstance()
		{
			vtkHoudiniPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHoudiniPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006350 RID: 25424
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHoudiniPolyDataWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006351 RID: 25425 RVA: 0x0008EE1C File Offset: 0x0008D01C
		public new static vtkHoudiniPolyDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkHoudiniPolyDataWriter vtkHoudiniPolyDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHoudiniPolyDataWriter = (vtkHoudiniPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHoudiniPolyDataWriter.Register(null);
				}
			}
			return vtkHoudiniPolyDataWriter;
		}

		// Token: 0x06006352 RID: 25426
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHoudiniPolyDataWriter_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies the delimited text file to be loaded.
		/// </summary>
		// Token: 0x06006353 RID: 25427 RVA: 0x0008EE9B File Offset: 0x0008D09B
		public virtual void SetFileName(string _arg)
		{
			vtkHoudiniPolyDataWriter.vtkHoudiniPolyDataWriter_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E3 RID: 2275
		public new const string MRFullTypeName = "Kitware.VTK.vtkHoudiniPolyDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E4 RID: 2276
		public new static readonly string MRClassNameKey = "class vtkHoudiniPolyDataWriter";
	}
}
