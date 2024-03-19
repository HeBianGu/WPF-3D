using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectReader
	/// </summary>
	/// <remarks>
	///    read vtk field data file
	///
	/// vtkDataObjectReader is a source object that reads ASCII or binary field
	/// data files in vtk format. Fields are general matrix structures used
	/// represent complex data. (See text for format details).  The output of this
	/// reader is a single vtkDataObject.  The superclass of this class,
	/// vtkDataReader, provides many methods for controlling the reading of the
	/// data file, see vtkDataReader for more information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataObjectWriter
	/// </seealso>
	// Token: 0x02000705 RID: 1797
	public class vtkDataObjectReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E4A RID: 77386 RVA: 0x001A9AA3 File Offset: 0x001A7CA3
		static vtkDataObjectReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E4B RID: 77387 RVA: 0x001A9ACB File Offset: 0x001A7CCB
		public vtkDataObjectReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E4C RID: 77388
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E4D RID: 77389 RVA: 0x001A9ADC File Offset: 0x001A7CDC
		public new static vtkDataObjectReader New()
		{
			vtkDataObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectReader.vtkDataObjectReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E4E RID: 77390 RVA: 0x001A9B30 File Offset: 0x001A7D30
		public vtkDataObjectReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectReader.vtkDataObjectReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E4F RID: 77391 RVA: 0x001A9B74 File Offset: 0x001A7D74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012E50 RID: 77392
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E51 RID: 77393 RVA: 0x001A9B80 File Offset: 0x001A7D80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectReader.vtkDataObjectReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012E52 RID: 77394
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E53 RID: 77395 RVA: 0x001A9BA0 File Offset: 0x001A7DA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectReader.vtkDataObjectReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012E54 RID: 77396
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output field of this reader.
		/// </summary>
		// Token: 0x06012E55 RID: 77397 RVA: 0x001A9BBC File Offset: 0x001A7DBC
		public vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectReader.vtkDataObjectReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06012E56 RID: 77398
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output field of this reader.
		/// </summary>
		// Token: 0x06012E57 RID: 77399 RVA: 0x001A9C2C File Offset: 0x001A7E2C
		public vtkDataObject GetOutput(int idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectReader.vtkDataObjectReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06012E58 RID: 77400
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E59 RID: 77401 RVA: 0x001A9C9C File Offset: 0x001A7E9C
		public override int IsA(string type)
		{
			return vtkDataObjectReader.vtkDataObjectReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012E5A RID: 77402
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E5B RID: 77403 RVA: 0x001A9CBC File Offset: 0x001A7EBC
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectReader.vtkDataObjectReader_IsTypeOf_06(type);
		}

		// Token: 0x06012E5C RID: 77404
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E5D RID: 77405 RVA: 0x001A9CD8 File Offset: 0x001A7ED8
		public new vtkDataObjectReader NewInstance()
		{
			vtkDataObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectReader.vtkDataObjectReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012E5E RID: 77406
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012E5F RID: 77407 RVA: 0x001A9D34 File Offset: 0x001A7F34
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkDataObjectReader.vtkDataObjectReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012E60 RID: 77408
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012E61 RID: 77409 RVA: 0x001A9D6C File Offset: 0x001A7F6C
		public new static vtkDataObjectReader SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectReader vtkDataObjectReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectReader.vtkDataObjectReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectReader = (vtkDataObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectReader.Register(null);
				}
			}
			return vtkDataObjectReader;
		}

		// Token: 0x06012E62 RID: 77410
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectReader_SetOutput_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the output field of this reader.
		/// </summary>
		// Token: 0x06012E63 RID: 77411 RVA: 0x001A9DEC File Offset: 0x001A7FEC
		public void SetOutput(vtkDataObject arg0)
		{
			vtkDataObjectReader.vtkDataObjectReader_SetOutput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D6 RID: 5590
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D7 RID: 5591
		public new static readonly string MRClassNameKey = "class vtkDataObjectReader";
	}
}
