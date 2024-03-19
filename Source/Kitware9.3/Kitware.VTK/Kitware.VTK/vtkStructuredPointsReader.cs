using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredPointsReader
	/// </summary>
	/// <remarks>
	///    read vtk structured points data file
	///
	/// vtkStructuredPointsReader is a source object that reads ASCII or binary
	/// structured points data files in vtk format (see text for format details).
	/// The output of this reader is a single vtkStructuredPoints data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkStructuredPoints vtkDataReader
	/// </seealso>
	// Token: 0x02000714 RID: 1812
	public class vtkStructuredPointsReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012FFE RID: 77822 RVA: 0x001AD1ED File Offset: 0x001AB3ED
		static vtkStructuredPointsReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012FFF RID: 77823 RVA: 0x001AD215 File Offset: 0x001AB415
		public vtkStructuredPointsReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013000 RID: 77824
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013001 RID: 77825 RVA: 0x001AD224 File Offset: 0x001AB424
		public new static vtkStructuredPointsReader New()
		{
			vtkStructuredPointsReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013002 RID: 77826 RVA: 0x001AD278 File Offset: 0x001AB478
		public vtkStructuredPointsReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredPointsReader.vtkStructuredPointsReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013003 RID: 77827 RVA: 0x001AD2BC File Offset: 0x001AB4BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013004 RID: 77828
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013005 RID: 77829 RVA: 0x001AD2C8 File Offset: 0x001AB4C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013006 RID: 77830
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013007 RID: 77831 RVA: 0x001AD2E8 File Offset: 0x001AB4E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013008 RID: 77832
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsReader_GetOutput_03(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the output of this reader.
		/// </summary>
		// Token: 0x06013009 RID: 77833 RVA: 0x001AD304 File Offset: 0x001AB504
		public vtkStructuredPoints GetOutput(int idx)
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_GetOutput_03(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0601300A RID: 77834
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsReader_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the output of this reader.
		/// </summary>
		// Token: 0x0601300B RID: 77835 RVA: 0x001AD374 File Offset: 0x001AB574
		public vtkStructuredPoints GetOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0601300C RID: 77836
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601300D RID: 77837 RVA: 0x001AD3E4 File Offset: 0x001AB5E4
		public override int IsA(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601300E RID: 77838
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601300F RID: 77839 RVA: 0x001AD404 File Offset: 0x001AB604
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_IsTypeOf_06(type);
		}

		// Token: 0x06013010 RID: 77840
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013011 RID: 77841 RVA: 0x001AD420 File Offset: 0x001AB620
		public new vtkStructuredPointsReader NewInstance()
		{
			vtkStructuredPointsReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013012 RID: 77842
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06013013 RID: 77843 RVA: 0x001AD47C File Offset: 0x001AB67C
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06013014 RID: 77844
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsReader_ReadMetaDataSimple_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef metadata);

		/// <summary>
		/// Read the meta information from the file (WHOLE_EXTENT).
		/// </summary>
		// Token: 0x06013015 RID: 77845 RVA: 0x001AD4B4 File Offset: 0x001AB6B4
		public override int ReadMetaDataSimple(string fname, vtkInformation metadata)
		{
			return vtkStructuredPointsReader.vtkStructuredPointsReader_ReadMetaDataSimple_10(base.GetCppThis(), fname, (metadata == null) ? default(HandleRef) : metadata.GetCppThis());
		}

		// Token: 0x06013016 RID: 77846
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013017 RID: 77847 RVA: 0x001AD4EC File Offset: 0x001AB6EC
		public new static vtkStructuredPointsReader SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsReader vtkStructuredPointsReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsReader.vtkStructuredPointsReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsReader = (vtkStructuredPointsReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsReader.Register(null);
				}
			}
			return vtkStructuredPointsReader;
		}

		// Token: 0x06013018 RID: 77848
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredPointsReader_SetOutput_12(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Set/Get the output of this reader.
		/// </summary>
		// Token: 0x06013019 RID: 77849 RVA: 0x001AD56C File Offset: 0x001AB76C
		public void SetOutput(vtkStructuredPoints output)
		{
			vtkStructuredPointsReader.vtkStructuredPointsReader_SetOutput_12(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F4 RID: 5620
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F5 RID: 5621
		public new static readonly string MRClassNameKey = "class vtkStructuredPointsReader";
	}
}
