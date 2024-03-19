using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageImport
	/// </summary>
	/// <remarks>
	///    Import data from a C array.
	///
	/// vtkImageImport provides methods needed to import image data from a source
	/// independent of VTK, such as a simple C array or a third-party pipeline.
	/// Note that the VTK convention is for the image voxel index (0,0,0) to be
	/// the lower-left corner of the image, while most 2D image formats use
	/// the upper-left corner.  You can use vtkImageFlip to correct the
	/// orientation after the image has been loaded into VTK.
	/// Note that is also possible to import the raw data from a Python string
	/// instead of from a C array. The array applies on scalar point data only, not
	/// on cell data.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageExport
	/// </seealso>
	// Token: 0x02000772 RID: 1906
	public class vtkImageImport : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013AD5 RID: 80597 RVA: 0x001BCB83 File Offset: 0x001BAD83
		static vtkImageImport()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageImport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageImport"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013AD6 RID: 80598 RVA: 0x001BCBAB File Offset: 0x001BADAB
		public vtkImageImport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013AD7 RID: 80599
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013AD8 RID: 80600 RVA: 0x001BCBBC File Offset: 0x001BADBC
		public new static vtkImageImport New()
		{
			vtkImageImport result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImport.vtkImageImport_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013AD9 RID: 80601 RVA: 0x001BCC10 File Offset: 0x001BAE10
		public vtkImageImport() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageImport.vtkImageImport_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013ADA RID: 80602 RVA: 0x001BCC54 File Offset: 0x001BAE54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013ADB RID: 80603
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_CopyImportVoidPointer_01(HandleRef pThis, IntPtr ptr, long size);

		/// <summary>
		/// Import data and make an internal copy of it.  If you do not want
		/// VTK to copy the data, then use SetImportVoidPointer instead (do
		/// not use both).  Give the size of the data array in bytes.
		/// </summary>
		// Token: 0x06013ADC RID: 80604 RVA: 0x001BCC5F File Offset: 0x001BAE5F
		public void CopyImportVoidPointer(IntPtr ptr, long size)
		{
			vtkImageImport.vtkImageImport_CopyImportVoidPointer_01(base.GetCppThis(), ptr, size);
		}

		// Token: 0x06013ADD RID: 80605
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.BufferPointerCallbackType vtkImageImport_GetBufferPointerCallback_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting a pointer to the data buffer of
		/// an image from a third-party pipeline.  The callback should return
		/// a pointer to the beginning of the buffer.  The extent of the
		/// buffer should be set with the DataExtentCallback.
		/// </summary>
		// Token: 0x06013ADE RID: 80606 RVA: 0x001BCC70 File Offset: 0x001BAE70
		public virtual vtkImageImport.BufferPointerCallbackType GetBufferPointerCallback()
		{
			return vtkImageImport.vtkImageImport_GetBufferPointerCallback_02(base.GetCppThis());
		}

		// Token: 0x06013ADF RID: 80607
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetCallbackUserData_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the user data which will be passed as the first argument
		/// to all of the third-party pipeline callbacks.
		/// </summary>
		// Token: 0x06013AE0 RID: 80608 RVA: 0x001BCC90 File Offset: 0x001BAE90
		public virtual IntPtr GetCallbackUserData()
		{
			return vtkImageImport.vtkImageImport_GetCallbackUserData_03(base.GetCppThis());
		}

		// Token: 0x06013AE1 RID: 80609
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetDataDirection_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
		/// the coordinates from index space (ijk) to physical space (xyz).
		/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
		/// </summary>
		// Token: 0x06013AE2 RID: 80610 RVA: 0x001BCCB0 File Offset: 0x001BAEB0
		public virtual double[] GetDataDirection()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataDirection_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013AE3 RID: 80611
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataDirection_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
		/// the coordinates from index space (ijk) to physical space (xyz).
		/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
		/// </summary>
		// Token: 0x06013AE4 RID: 80612 RVA: 0x001BCCF9 File Offset: 0x001BAEF9
		public virtual void GetDataDirection(IntPtr data)
		{
			vtkImageImport.vtkImageImport_GetDataDirection_05(base.GetCppThis(), data);
		}

		// Token: 0x06013AE5 RID: 80613
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetDataExtent_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013AE6 RID: 80614 RVA: 0x001BCD0C File Offset: 0x001BAF0C
		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataExtent_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013AE7 RID: 80615
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataExtent_07(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013AE8 RID: 80616 RVA: 0x001BCD54 File Offset: 0x001BAF54
		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageImport.vtkImageImport_GetDataExtent_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06013AE9 RID: 80617
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataExtent_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013AEA RID: 80618 RVA: 0x001BCD6C File Offset: 0x001BAF6C
		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataExtent_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06013AEB RID: 80619
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.DataExtentCallbackType vtkImageImport_GetDataExtentCallback_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the data extent of the input
		/// image from a third-party pipeline.  The callback should return a
		/// vector of six integers describing the extent of the buffered
		/// portion of the image (x1 x2 y1 y2 z1 z2).  The buffer location
		/// should be set with the BufferPointerCallback.
		/// </summary>
		// Token: 0x06013AEC RID: 80620 RVA: 0x001BCD7C File Offset: 0x001BAF7C
		public virtual vtkImageImport.DataExtentCallbackType GetDataExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetDataExtentCallback_09(base.GetCppThis());
		}

		// Token: 0x06013AED RID: 80621
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetDataOrigin_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
		/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06013AEE RID: 80622 RVA: 0x001BCD9C File Offset: 0x001BAF9C
		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataOrigin_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013AEF RID: 80623
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataOrigin_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
		/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06013AF0 RID: 80624 RVA: 0x001BCDE4 File Offset: 0x001BAFE4
		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageImport.vtkImageImport_GetDataOrigin_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013AF1 RID: 80625
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataOrigin_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
		/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06013AF2 RID: 80626 RVA: 0x001BCDF6 File Offset: 0x001BAFF6
		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataOrigin_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06013AF3 RID: 80627
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImport_GetDataScalarType_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013AF4 RID: 80628 RVA: 0x001BCE08 File Offset: 0x001BB008
		public virtual int GetDataScalarType()
		{
			return vtkImageImport.vtkImageImport_GetDataScalarType_13(base.GetCppThis());
		}

		// Token: 0x06013AF5 RID: 80629
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetDataScalarTypeAsString_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013AF6 RID: 80630 RVA: 0x001BCE28 File Offset: 0x001BB028
		public string GetDataScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageImport.vtkImageImport_GetDataScalarTypeAsString_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013AF7 RID: 80631
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetDataSpacing_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the spacing (typically in mm) between image voxels.
		/// Default: (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06013AF8 RID: 80632 RVA: 0x001BCE64 File Offset: 0x001BB064
		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetDataSpacing_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013AF9 RID: 80633
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataSpacing_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the spacing (typically in mm) between image voxels.
		/// Default: (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06013AFA RID: 80634 RVA: 0x001BCEAC File Offset: 0x001BB0AC
		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageImport.vtkImageImport_GetDataSpacing_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013AFB RID: 80635
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetDataSpacing_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the spacing (typically in mm) between image voxels.
		/// Default: (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06013AFC RID: 80636 RVA: 0x001BCEBE File Offset: 0x001BB0BE
		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetDataSpacing_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06013AFD RID: 80637
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.DirectionCallbackType vtkImageImport_GetDirectionCallback_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the direction of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of nine double values describing the rotation from ijk to xyz.
		/// </summary>
		// Token: 0x06013AFE RID: 80638 RVA: 0x001BCED0 File Offset: 0x001BB0D0
		public virtual vtkImageImport.DirectionCallbackType GetDirectionCallback()
		{
			return vtkImageImport.vtkImageImport_GetDirectionCallback_18(base.GetCppThis());
		}

		// Token: 0x06013AFF RID: 80639
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetImportVoidPointer_19(HandleRef pThis);

		/// <summary>
		/// Set the pointer from which the image data is imported.  VTK will
		/// not make its own copy of the data, it will access the data directly
		/// from the supplied array.  VTK will not attempt to delete the data
		/// nor modify the data.
		/// </summary>
		// Token: 0x06013B00 RID: 80640 RVA: 0x001BCEF0 File Offset: 0x001BB0F0
		public IntPtr GetImportVoidPointer()
		{
			return vtkImageImport.vtkImageImport_GetImportVoidPointer_19(base.GetCppThis());
		}

		// Token: 0x06013B01 RID: 80641
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.NumberOfComponentsCallbackType vtkImageImport_GetNumberOfComponentsCallback_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the number of components of the
		/// input image from a third-party pipeline.  The callback should
		/// return an integer with the number of components.
		/// </summary>
		// Token: 0x06013B02 RID: 80642 RVA: 0x001BCF10 File Offset: 0x001BB110
		public virtual vtkImageImport.NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
		{
			return vtkImageImport.vtkImageImport_GetNumberOfComponentsCallback_20(base.GetCppThis());
		}

		// Token: 0x06013B03 RID: 80643
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageImport_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B04 RID: 80644 RVA: 0x001BCF30 File Offset: 0x001BB130
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageImport.vtkImageImport_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x06013B05 RID: 80645
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageImport_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B06 RID: 80646 RVA: 0x001BCF50 File Offset: 0x001BB150
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageImport.vtkImageImport_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x06013B07 RID: 80647
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImport_GetNumberOfScalarComponents_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of scalar components, for RGB images this must be 3.
		/// Default: 1.
		/// </summary>
		// Token: 0x06013B08 RID: 80648 RVA: 0x001BCF6C File Offset: 0x001BB16C
		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageImport.vtkImageImport_GetNumberOfScalarComponents_23(base.GetCppThis());
		}

		// Token: 0x06013B09 RID: 80649
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.DirectionCallbackType vtkImageImport_GetOriginCallback_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the origin of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of three double values describing the origin (x0 y0 z0).
		/// </summary>
		// Token: 0x06013B0A RID: 80650 RVA: 0x001BCF8C File Offset: 0x001BB18C
		public virtual vtkImageImport.DirectionCallbackType GetOriginCallback()
		{
			return vtkImageImport.vtkImageImport_GetOriginCallback_24(base.GetCppThis());
		}

		// Token: 0x06013B0B RID: 80651
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.NumberOfComponentsCallbackType vtkImageImport_GetPipelineModifiedCallback_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for checking whether the third-party
		/// pipeline has been modified since the last invocation of the
		/// callback.  The callback should return 1 for modified, and 0 for
		/// not modified.  The first call should always return modified.
		/// </summary>
		// Token: 0x06013B0C RID: 80652 RVA: 0x001BCFAC File Offset: 0x001BB1AC
		public virtual vtkImageImport.NumberOfComponentsCallbackType GetPipelineModifiedCallback()
		{
			return vtkImageImport.vtkImageImport_GetPipelineModifiedCallback_25(base.GetCppThis());
		}

		// Token: 0x06013B0D RID: 80653
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.PropagateUpdateExtentCallbackType vtkImageImport_GetPropagateUpdateExtentCallback_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for propagating the pipeline update extent
		/// to a third-party pipeline.  The callback should take a vector of
		/// six integers describing the extent.  This should cause the
		/// third-party pipeline to provide data which contains at least this
		/// extent after the next UpdateData callback.
		/// </summary>
		// Token: 0x06013B0E RID: 80654 RVA: 0x001BCFCC File Offset: 0x001BB1CC
		public virtual vtkImageImport.PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetPropagateUpdateExtentCallback_26(base.GetCppThis());
		}

		// Token: 0x06013B0F RID: 80655
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetScalarArrayName_27(HandleRef pThis);

		/// <summary>
		/// Set/get the scalar array name for this data set. Initial value is
		/// "scalars".
		/// </summary>
		// Token: 0x06013B10 RID: 80656 RVA: 0x001BCFEC File Offset: 0x001BB1EC
		public virtual string GetScalarArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageImport.vtkImageImport_GetScalarArrayName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013B11 RID: 80657
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.ScalarTypeCallbackType vtkImageImport_GetScalarTypeCallback_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the scalar value type of the
		/// input image from a third-party pipeline.  The callback should
		/// return a string with the name of the type.
		/// </summary>
		// Token: 0x06013B12 RID: 80658 RVA: 0x001BD028 File Offset: 0x001BB228
		public virtual vtkImageImport.ScalarTypeCallbackType GetScalarTypeCallback()
		{
			return vtkImageImport.vtkImageImport_GetScalarTypeCallback_28(base.GetCppThis());
		}

		// Token: 0x06013B13 RID: 80659
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.DirectionCallbackType vtkImageImport_GetSpacingCallback_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the spacing of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of three double values describing the spacing (dx dy dz).
		/// </summary>
		// Token: 0x06013B14 RID: 80660 RVA: 0x001BD048 File Offset: 0x001BB248
		public virtual vtkImageImport.DirectionCallbackType GetSpacingCallback()
		{
			return vtkImageImport.vtkImageImport_GetSpacingCallback_29(base.GetCppThis());
		}

		// Token: 0x06013B15 RID: 80661
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.UpdateDataCallbackType vtkImageImport_GetUpdateDataCallback_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for propagating UpdateData calls to a
		/// third-party pipeline.  The callback should make sure the
		/// third-party pipeline is up to date.
		/// </summary>
		// Token: 0x06013B16 RID: 80662 RVA: 0x001BD068 File Offset: 0x001BB268
		public virtual vtkImageImport.UpdateDataCallbackType GetUpdateDataCallback()
		{
			return vtkImageImport.vtkImageImport_GetUpdateDataCallback_30(base.GetCppThis());
		}

		// Token: 0x06013B17 RID: 80663
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.UpdateDataCallbackType vtkImageImport_GetUpdateInformationCallback_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for propagating UpdateInformation calls to a
		/// third-party pipeline.  The callback should make sure that the
		/// third-party pipeline information is up to date.
		/// </summary>
		// Token: 0x06013B18 RID: 80664 RVA: 0x001BD088 File Offset: 0x001BB288
		public virtual vtkImageImport.UpdateDataCallbackType GetUpdateInformationCallback()
		{
			return vtkImageImport.vtkImageImport_GetUpdateInformationCallback_31(base.GetCppThis());
		}

		// Token: 0x06013B19 RID: 80665
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_GetWholeExtent_32(HandleRef pThis);

		/// <summary>
		/// Get/Set the whole extent of the image.  This is the largest possible
		/// extent.  Set the DataExtent to the extent of the image in the buffer
		/// pointed to by the ImportVoidPointer.
		/// </summary>
		// Token: 0x06013B1A RID: 80666 RVA: 0x001BD0A8 File Offset: 0x001BB2A8
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageImport.vtkImageImport_GetWholeExtent_32(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013B1B RID: 80667
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetWholeExtent_33(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the whole extent of the image.  This is the largest possible
		/// extent.  Set the DataExtent to the extent of the image in the buffer
		/// pointed to by the ImportVoidPointer.
		/// </summary>
		// Token: 0x06013B1C RID: 80668 RVA: 0x001BD0F0 File Offset: 0x001BB2F0
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageImport.vtkImageImport_GetWholeExtent_33(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06013B1D RID: 80669
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_GetWholeExtent_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extent of the image.  This is the largest possible
		/// extent.  Set the DataExtent to the extent of the image in the buffer
		/// pointed to by the ImportVoidPointer.
		/// </summary>
		// Token: 0x06013B1E RID: 80670 RVA: 0x001BD108 File Offset: 0x001BB308
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_GetWholeExtent_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B1F RID: 80671
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageImport.DataExtentCallbackType vtkImageImport_GetWholeExtentCallback_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the callback for getting the whole extent of the input
		/// image from a third-party pipeline.  The callback should return a
		/// vector of six integers describing the extent of the whole image
		/// (x1 x2 y1 y2 z1 z2).
		/// </summary>
		// Token: 0x06013B20 RID: 80672 RVA: 0x001BD118 File Offset: 0x001BB318
		public virtual vtkImageImport.DataExtentCallbackType GetWholeExtentCallback()
		{
			return vtkImageImport.vtkImageImport_GetWholeExtentCallback_35(base.GetCppThis());
		}

		// Token: 0x06013B21 RID: 80673
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_InvokeExecuteDataCallbacks_36(HandleRef pThis);

		/// <summary>
		/// Invoke the appropriate callbacks
		/// </summary>
		// Token: 0x06013B22 RID: 80674 RVA: 0x001BD137 File Offset: 0x001BB337
		public void InvokeExecuteDataCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeExecuteDataCallbacks_36(base.GetCppThis());
		}

		// Token: 0x06013B23 RID: 80675
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_InvokeExecuteInformationCallbacks_37(HandleRef pThis);

		/// <summary>
		/// Invoke the appropriate callbacks
		/// </summary>
		// Token: 0x06013B24 RID: 80676 RVA: 0x001BD146 File Offset: 0x001BB346
		public void InvokeExecuteInformationCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeExecuteInformationCallbacks_37(base.GetCppThis());
		}

		// Token: 0x06013B25 RID: 80677
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImport_InvokePipelineModifiedCallbacks_38(HandleRef pThis);

		/// <summary>
		/// Invoke the appropriate callbacks
		/// </summary>
		// Token: 0x06013B26 RID: 80678 RVA: 0x001BD158 File Offset: 0x001BB358
		public int InvokePipelineModifiedCallbacks()
		{
			return vtkImageImport.vtkImageImport_InvokePipelineModifiedCallbacks_38(base.GetCppThis());
		}

		// Token: 0x06013B27 RID: 80679
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_InvokeUpdateInformationCallbacks_39(HandleRef pThis);

		/// <summary>
		/// Invoke the appropriate callbacks
		/// </summary>
		// Token: 0x06013B28 RID: 80680 RVA: 0x001BD177 File Offset: 0x001BB377
		public void InvokeUpdateInformationCallbacks()
		{
			vtkImageImport.vtkImageImport_InvokeUpdateInformationCallbacks_39(base.GetCppThis());
		}

		// Token: 0x06013B29 RID: 80681
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImport_IsA_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B2A RID: 80682 RVA: 0x001BD188 File Offset: 0x001BB388
		public override int IsA(string type)
		{
			return vtkImageImport.vtkImageImport_IsA_40(base.GetCppThis(), type);
		}

		// Token: 0x06013B2B RID: 80683
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImport_IsTypeOf_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B2C RID: 80684 RVA: 0x001BD1A8 File Offset: 0x001BB3A8
		public new static int IsTypeOf(string type)
		{
			return vtkImageImport.vtkImageImport_IsTypeOf_41(type);
		}

		// Token: 0x06013B2D RID: 80685
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_LegacyCheckWholeExtent_42(HandleRef pThis);

		/// <summary>
		/// Invoke the appropriate callbacks
		/// </summary>
		// Token: 0x06013B2E RID: 80686 RVA: 0x001BD1C2 File Offset: 0x001BB3C2
		public void LegacyCheckWholeExtent()
		{
			vtkImageImport.vtkImageImport_LegacyCheckWholeExtent_42(base.GetCppThis());
		}

		// Token: 0x06013B2F RID: 80687
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B30 RID: 80688 RVA: 0x001BD1D4 File Offset: 0x001BB3D4
		public new vtkImageImport NewInstance()
		{
			vtkImageImport result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImport.vtkImageImport_NewInstance_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013B31 RID: 80689
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImport_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013B32 RID: 80690 RVA: 0x001BD230 File Offset: 0x001BB430
		public new static vtkImageImport SafeDownCast(vtkObjectBase o)
		{
			vtkImageImport vtkImageImport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImport.vtkImageImport_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageImport = (vtkImageImport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageImport.Register(null);
				}
			}
			return vtkImageImport;
		}

		// Token: 0x06013B33 RID: 80691
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetBufferPointerCallback_46(HandleRef pThis, vtkImageImport.BufferPointerCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting a pointer to the data buffer of
		/// an image from a third-party pipeline.  The callback should return
		/// a pointer to the beginning of the buffer.  The extent of the
		/// buffer should be set with the DataExtentCallback.
		/// </summary>
		// Token: 0x06013B34 RID: 80692 RVA: 0x001BD2AF File Offset: 0x001BB4AF
		public virtual void SetBufferPointerCallback(vtkImageImport.BufferPointerCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetBufferPointerCallback_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B35 RID: 80693
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetCallbackUserData_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the user data which will be passed as the first argument
		/// to all of the third-party pipeline callbacks.
		/// </summary>
		// Token: 0x06013B36 RID: 80694 RVA: 0x001BD2BF File Offset: 0x001BB4BF
		public virtual void SetCallbackUserData(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetCallbackUserData_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B37 RID: 80695
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataDirection_48(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the direction of the data, i.e. the 3x3 matrix to rotate
		/// the coordinates from index space (ijk) to physical space (xyz).
		/// Default: Identity Matrix (1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0)
		/// </summary>
		// Token: 0x06013B38 RID: 80696 RVA: 0x001BD2CF File Offset: 0x001BB4CF
		public virtual void SetDataDirection(IntPtr data)
		{
			vtkImageImport.vtkImageImport_SetDataDirection_48(base.GetCppThis(), data);
		}

		// Token: 0x06013B39 RID: 80697
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataExtent_49(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013B3A RID: 80698 RVA: 0x001BD2DF File Offset: 0x001BB4DF
		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageImport.vtkImageImport_SetDataExtent_49(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06013B3B RID: 80699
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataExtent_50(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013B3C RID: 80700 RVA: 0x001BD2F7 File Offset: 0x001BB4F7
		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataExtent_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B3D RID: 80701
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataExtentCallback_51(HandleRef pThis, vtkImageImport.DataExtentCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the data extent of the input
		/// image from a third-party pipeline.  The callback should return a
		/// vector of six integers describing the extent of the buffered
		/// portion of the image (x1 x2 y1 y2 z1 z2).  The buffer location
		/// should be set with the BufferPointerCallback.
		/// </summary>
		// Token: 0x06013B3E RID: 80702 RVA: 0x001BD307 File Offset: 0x001BB507
		public virtual void SetDataExtentCallback(vtkImageImport.DataExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetDataExtentCallback_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B3F RID: 80703
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataExtentToWholeExtent_52(HandleRef pThis);

		/// <summary>
		/// Get/Set the extent of the data buffer.  The dimensions of your data
		/// must be equal to (extent[1]-extent[0]+1) * (extent[3]-extent[2]+1) *
		/// (extent[5]-DataExtent[4]+1).  For example, for a 2D image use
		/// (0,width-1, 0,height-1, 0,0).
		/// </summary>
		// Token: 0x06013B40 RID: 80704 RVA: 0x001BD317 File Offset: 0x001BB517
		public void SetDataExtentToWholeExtent()
		{
			vtkImageImport.vtkImageImport_SetDataExtentToWholeExtent_52(base.GetCppThis());
		}

		// Token: 0x06013B41 RID: 80705
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataOrigin_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
		/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06013B42 RID: 80706 RVA: 0x001BD326 File Offset: 0x001BB526
		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageImport.vtkImageImport_SetDataOrigin_53(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06013B43 RID: 80707
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataOrigin_54(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the data, i.e. the coordinates (usually in mm)
		/// of voxel (0,0,0).  Default: (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06013B44 RID: 80708 RVA: 0x001BD338 File Offset: 0x001BB538
		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataOrigin_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B45 RID: 80709
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarType_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B46 RID: 80710 RVA: 0x001BD348 File Offset: 0x001BB548
		public virtual void SetDataScalarType(int _arg)
		{
			vtkImageImport.vtkImageImport_SetDataScalarType_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B47 RID: 80711
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToDouble_56(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B48 RID: 80712 RVA: 0x001BD358 File Offset: 0x001BB558
		public void SetDataScalarTypeToDouble()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToDouble_56(base.GetCppThis());
		}

		// Token: 0x06013B49 RID: 80713
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToFloat_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B4A RID: 80714 RVA: 0x001BD367 File Offset: 0x001BB567
		public void SetDataScalarTypeToFloat()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToFloat_57(base.GetCppThis());
		}

		// Token: 0x06013B4B RID: 80715
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToInt_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B4C RID: 80716 RVA: 0x001BD376 File Offset: 0x001BB576
		public void SetDataScalarTypeToInt()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToInt_58(base.GetCppThis());
		}

		// Token: 0x06013B4D RID: 80717
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToShort_59(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B4E RID: 80718 RVA: 0x001BD385 File Offset: 0x001BB585
		public void SetDataScalarTypeToShort()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToShort_59(base.GetCppThis());
		}

		// Token: 0x06013B4F RID: 80719
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedChar_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B50 RID: 80720 RVA: 0x001BD394 File Offset: 0x001BB594
		public void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToUnsignedChar_60(base.GetCppThis());
		}

		// Token: 0x06013B51 RID: 80721
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataScalarTypeToUnsignedShort_61(HandleRef pThis);

		/// <summary>
		/// Set/Get the data type of pixels in the imported data.  This is used
		/// as the scalar type of the Output.  Default: Short.
		/// </summary>
		// Token: 0x06013B52 RID: 80722 RVA: 0x001BD3A3 File Offset: 0x001BB5A3
		public void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageImport.vtkImageImport_SetDataScalarTypeToUnsignedShort_61(base.GetCppThis());
		}

		// Token: 0x06013B53 RID: 80723
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataSpacing_62(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the spacing (typically in mm) between image voxels.
		/// Default: (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06013B54 RID: 80724 RVA: 0x001BD3B2 File Offset: 0x001BB5B2
		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageImport.vtkImageImport_SetDataSpacing_62(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06013B55 RID: 80725
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDataSpacing_63(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the spacing (typically in mm) between image voxels.
		/// Default: (1.0, 1.0, 1.0).
		/// </summary>
		// Token: 0x06013B56 RID: 80726 RVA: 0x001BD3C4 File Offset: 0x001BB5C4
		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetDataSpacing_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B57 RID: 80727
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetDirectionCallback_64(HandleRef pThis, vtkImageImport.DirectionCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the direction of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of nine double values describing the rotation from ijk to xyz.
		/// </summary>
		// Token: 0x06013B58 RID: 80728 RVA: 0x001BD3D4 File Offset: 0x001BB5D4
		public virtual void SetDirectionCallback(vtkImageImport.DirectionCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetDirectionCallback_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B59 RID: 80729
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetImportVoidPointer_65(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Set the pointer from which the image data is imported.  VTK will
		/// not make its own copy of the data, it will access the data directly
		/// from the supplied array.  VTK will not attempt to delete the data
		/// nor modify the data.
		/// </summary>
		// Token: 0x06013B5A RID: 80730 RVA: 0x001BD3E4 File Offset: 0x001BB5E4
		public void SetImportVoidPointer(IntPtr ptr)
		{
			vtkImageImport.vtkImageImport_SetImportVoidPointer_65(base.GetCppThis(), ptr);
		}

		// Token: 0x06013B5B RID: 80731
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetImportVoidPointer_66(HandleRef pThis, IntPtr ptr, int save);

		/// <summary>
		/// Set the pointer from which the image data is imported.  Set save to 1
		/// (the default) unless you want VTK to delete the array via C++ delete
		/// when the vtkImageImport object is deallocated.  VTK will not make its
		/// own copy of the data, it will access the data directly from the
		/// supplied array.
		/// </summary>
		// Token: 0x06013B5C RID: 80732 RVA: 0x001BD3F4 File Offset: 0x001BB5F4
		public void SetImportVoidPointer(IntPtr ptr, int save)
		{
			vtkImageImport.vtkImageImport_SetImportVoidPointer_66(base.GetCppThis(), ptr, save);
		}

		// Token: 0x06013B5D RID: 80733
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetNumberOfComponentsCallback_67(HandleRef pThis, vtkImageImport.NumberOfComponentsCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the number of components of the
		/// input image from a third-party pipeline.  The callback should
		/// return an integer with the number of components.
		/// </summary>
		// Token: 0x06013B5E RID: 80734 RVA: 0x001BD405 File Offset: 0x001BB605
		public virtual void SetNumberOfComponentsCallback(vtkImageImport.NumberOfComponentsCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetNumberOfComponentsCallback_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B5F RID: 80735
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetNumberOfScalarComponents_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of scalar components, for RGB images this must be 3.
		/// Default: 1.
		/// </summary>
		// Token: 0x06013B60 RID: 80736 RVA: 0x001BD415 File Offset: 0x001BB615
		public virtual void SetNumberOfScalarComponents(int _arg)
		{
			vtkImageImport.vtkImageImport_SetNumberOfScalarComponents_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B61 RID: 80737
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetOriginCallback_69(HandleRef pThis, vtkImageImport.DirectionCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the origin of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of three double values describing the origin (x0 y0 z0).
		/// </summary>
		// Token: 0x06013B62 RID: 80738 RVA: 0x001BD425 File Offset: 0x001BB625
		public virtual void SetOriginCallback(vtkImageImport.DirectionCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetOriginCallback_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B63 RID: 80739
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetPipelineModifiedCallback_70(HandleRef pThis, vtkImageImport.NumberOfComponentsCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for checking whether the third-party
		/// pipeline has been modified since the last invocation of the
		/// callback.  The callback should return 1 for modified, and 0 for
		/// not modified.  The first call should always return modified.
		/// </summary>
		// Token: 0x06013B64 RID: 80740 RVA: 0x001BD435 File Offset: 0x001BB635
		public virtual void SetPipelineModifiedCallback(vtkImageImport.NumberOfComponentsCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetPipelineModifiedCallback_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B65 RID: 80741
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetPropagateUpdateExtentCallback_71(HandleRef pThis, vtkImageImport.PropagateUpdateExtentCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for propagating the pipeline update extent
		/// to a third-party pipeline.  The callback should take a vector of
		/// six integers describing the extent.  This should cause the
		/// third-party pipeline to provide data which contains at least this
		/// extent after the next UpdateData callback.
		/// </summary>
		// Token: 0x06013B66 RID: 80742 RVA: 0x001BD445 File Offset: 0x001BB645
		public virtual void SetPropagateUpdateExtentCallback(vtkImageImport.PropagateUpdateExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetPropagateUpdateExtentCallback_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B67 RID: 80743
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetScalarArrayName_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the scalar array name for this data set. Initial value is
		/// "scalars".
		/// </summary>
		// Token: 0x06013B68 RID: 80744 RVA: 0x001BD455 File Offset: 0x001BB655
		public virtual void SetScalarArrayName(string _arg)
		{
			vtkImageImport.vtkImageImport_SetScalarArrayName_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B69 RID: 80745
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetScalarTypeCallback_73(HandleRef pThis, vtkImageImport.ScalarTypeCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the scalar value type of the
		/// input image from a third-party pipeline.  The callback should
		/// return a string with the name of the type.
		/// </summary>
		// Token: 0x06013B6A RID: 80746 RVA: 0x001BD465 File Offset: 0x001BB665
		public virtual void SetScalarTypeCallback(vtkImageImport.ScalarTypeCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetScalarTypeCallback_73(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B6B RID: 80747
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetSpacingCallback_74(HandleRef pThis, vtkImageImport.DirectionCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the spacing of the input image
		/// from a third-party pipeline.  The callback should return a vector
		/// of three double values describing the spacing (dx dy dz).
		/// </summary>
		// Token: 0x06013B6C RID: 80748 RVA: 0x001BD475 File Offset: 0x001BB675
		public virtual void SetSpacingCallback(vtkImageImport.DirectionCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetSpacingCallback_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B6D RID: 80749
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetUpdateDataCallback_75(HandleRef pThis, vtkImageImport.UpdateDataCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for propagating UpdateData calls to a
		/// third-party pipeline.  The callback should make sure the
		/// third-party pipeline is up to date.
		/// </summary>
		// Token: 0x06013B6E RID: 80750 RVA: 0x001BD485 File Offset: 0x001BB685
		public virtual void SetUpdateDataCallback(vtkImageImport.UpdateDataCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetUpdateDataCallback_75(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B6F RID: 80751
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetUpdateInformationCallback_76(HandleRef pThis, vtkImageImport.UpdateDataCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for propagating UpdateInformation calls to a
		/// third-party pipeline.  The callback should make sure that the
		/// third-party pipeline information is up to date.
		/// </summary>
		// Token: 0x06013B70 RID: 80752 RVA: 0x001BD495 File Offset: 0x001BB695
		public virtual void SetUpdateInformationCallback(vtkImageImport.UpdateDataCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetUpdateInformationCallback_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B71 RID: 80753
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetWholeExtent_77(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the whole extent of the image.  This is the largest possible
		/// extent.  Set the DataExtent to the extent of the image in the buffer
		/// pointed to by the ImportVoidPointer.
		/// </summary>
		// Token: 0x06013B72 RID: 80754 RVA: 0x001BD4A5 File Offset: 0x001BB6A5
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageImport.vtkImageImport_SetWholeExtent_77(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06013B73 RID: 80755
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetWholeExtent_78(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the whole extent of the image.  This is the largest possible
		/// extent.  Set the DataExtent to the extent of the image in the buffer
		/// pointed to by the ImportVoidPointer.
		/// </summary>
		// Token: 0x06013B74 RID: 80756 RVA: 0x001BD4BD File Offset: 0x001BB6BD
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkImageImport.vtkImageImport_SetWholeExtent_78(base.GetCppThis(), _arg);
		}

		// Token: 0x06013B75 RID: 80757
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageImport_SetWholeExtentCallback_79(HandleRef pThis, vtkImageImport.DataExtentCallbackType _arg);

		/// <summary>
		/// Set/Get the callback for getting the whole extent of the input
		/// image from a third-party pipeline.  The callback should return a
		/// vector of six integers describing the extent of the whole image
		/// (x1 x2 y1 y2 z1 z2).
		/// </summary>
		// Token: 0x06013B76 RID: 80758 RVA: 0x001BD4CD File Offset: 0x001BB6CD
		public virtual void SetWholeExtentCallback(vtkImageImport.DataExtentCallbackType _arg)
		{
			vtkImageImport.vtkImageImport_SetWholeExtentCallback_79(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016AB RID: 5803
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageImport";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016AC RID: 5804
		public new static readonly string MRClassNameKey = "class vtkImageImport";

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000773 RID: 1907
		// (Invoke) Token: 0x06013B78 RID: 80760
		public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000774 RID: 1908
		// (Invoke) Token: 0x06013B7C RID: 80764
		public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000775 RID: 1909
		// (Invoke) Token: 0x06013B80 RID: 80768
		public delegate IntPtr DirectionCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000776 RID: 1910
		// (Invoke) Token: 0x06013B84 RID: 80772
		public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000777 RID: 1911
		// (Invoke) Token: 0x06013B88 RID: 80776
		public delegate IntPtr OriginCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000778 RID: 1912
		// (Invoke) Token: 0x06013B8C RID: 80780
		public delegate int PipelineModifiedCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x02000779 RID: 1913
		// (Invoke) Token: 0x06013B90 RID: 80784
		public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x0200077A RID: 1914
		// (Invoke) Token: 0x06013B94 RID: 80788
		public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x0200077B RID: 1915
		// (Invoke) Token: 0x06013B98 RID: 80792
		public delegate IntPtr SpacingCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x0200077C RID: 1916
		// (Invoke) Token: 0x06013B9C RID: 80796
		public delegate void UpdateDataCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x0200077D RID: 1917
		// (Invoke) Token: 0x06013BA0 RID: 80800
		public delegate void UpdateInformationCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation on each individual callback.
		/// </summary>
		// Token: 0x0200077E RID: 1918
		// (Invoke) Token: 0x06013BA4 RID: 80804
		public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);
	}
}
