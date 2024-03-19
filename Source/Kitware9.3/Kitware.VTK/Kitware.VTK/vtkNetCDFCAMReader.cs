using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFCAMReader
	/// </summary>
	/// <remarks>
	///    Read unstructured NetCDF CAM files.
	///
	/// Reads in a NetCDF CAM (Community Atmospheric Model) file and
	/// produces and unstructured grid.  The grid is actually unstructured
	/// in the X and Y directions and rectilinear in the Z direction. If we
	/// read one layer we produce quad cells otherwise we produce hex
	/// cells.  The reader requires 2 NetCDF files: the main file has all
	/// attributes, the connectivity file has point positions and cell
	/// connectivity information.
	/// </remarks>
	// Token: 0x0200016C RID: 364
	public class vtkNetCDFCAMReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600459E RID: 17822 RVA: 0x00065514 File Offset: 0x00063714
		static vtkNetCDFCAMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFCAMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFCAMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600459F RID: 17823 RVA: 0x0006553C File Offset: 0x0006373C
		public vtkNetCDFCAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060045A0 RID: 17824
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045A1 RID: 17825 RVA: 0x0006554C File Offset: 0x0006374C
		public new static vtkNetCDFCAMReader New()
		{
			vtkNetCDFCAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCAMReader.vtkNetCDFCAMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045A2 RID: 17826 RVA: 0x000655A0 File Offset: 0x000637A0
		public vtkNetCDFCAMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFCAMReader.vtkNetCDFCAMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060045A3 RID: 17827 RVA: 0x000655E4 File Offset: 0x000637E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060045A4 RID: 17828
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because NetCDF CAM files come in pairs and we only check one of the
		/// files, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x060045A5 RID: 17829 RVA: 0x000655F0 File Offset: 0x000637F0
		public static int CanReadFile(string fileName)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_CanReadFile_01(fileName);
		}

		// Token: 0x060045A6 RID: 17830
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_DisableAllPointArrays_02(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045A7 RID: 17831 RVA: 0x0006560A File Offset: 0x0006380A
		public void DisableAllPointArrays()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_DisableAllPointArrays_02(base.GetCppThis());
		}

		// Token: 0x060045A8 RID: 17832
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_EnableAllPointArrays_03(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045A9 RID: 17833 RVA: 0x00065619 File Offset: 0x00063819
		public void EnableAllPointArrays()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_EnableAllPointArrays_03(base.GetCppThis());
		}

		// Token: 0x060045AA RID: 17834
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_GetConnectivityFileName_04(HandleRef pThis);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because NetCDF CAM files come in pairs and we only check one of the
		/// files, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x060045AB RID: 17835 RVA: 0x00065628 File Offset: 0x00063828
		public virtual string GetConnectivityFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetConnectivityFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060045AC RID: 17836
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because NetCDF CAM files come in pairs and we only check one of the
		/// files, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x060045AD RID: 17837 RVA: 0x00065664 File Offset: 0x00063864
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060045AE RID: 17838
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetInterfaceLayerIndex_06(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045AF RID: 17839 RVA: 0x000656A0 File Offset: 0x000638A0
		public virtual int GetInterfaceLayerIndex()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetInterfaceLayerIndex_06(base.GetCppThis());
		}

		// Token: 0x060045B0 RID: 17840
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_GetInterfaceLayersRange_07(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045B1 RID: 17841 RVA: 0x000656C0 File Offset: 0x000638C0
		public virtual int[] GetInterfaceLayersRange()
		{
			IntPtr intPtr = vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetInterfaceLayersRange_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060045B2 RID: 17842
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_GetInterfaceLayersRange_08(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045B3 RID: 17843 RVA: 0x00065708 File Offset: 0x00063908
		public virtual void GetInterfaceLayersRange(ref int _arg1, ref int _arg2)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetInterfaceLayersRange_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060045B4 RID: 17844
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_GetInterfaceLayersRange_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045B5 RID: 17845 RVA: 0x00065719 File Offset: 0x00063919
		public virtual void GetInterfaceLayersRange(IntPtr _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetInterfaceLayersRange_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060045B6 RID: 17846
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetMidpointLayerIndex_10(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045B7 RID: 17847 RVA: 0x0006572C File Offset: 0x0006392C
		public virtual int GetMidpointLayerIndex()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetMidpointLayerIndex_10(base.GetCppThis());
		}

		// Token: 0x060045B8 RID: 17848
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_GetMidpointLayersRange_11(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045B9 RID: 17849 RVA: 0x0006574C File Offset: 0x0006394C
		public virtual int[] GetMidpointLayersRange()
		{
			IntPtr intPtr = vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetMidpointLayersRange_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060045BA RID: 17850
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_GetMidpointLayersRange_12(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045BB RID: 17851 RVA: 0x00065794 File Offset: 0x00063994
		public virtual void GetMidpointLayersRange(ref int _arg1, ref int _arg2)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetMidpointLayersRange_12(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060045BC RID: 17852
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_GetMidpointLayersRange_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045BD RID: 17853 RVA: 0x000657A5 File Offset: 0x000639A5
		public virtual void GetMidpointLayersRange(IntPtr _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetMidpointLayersRange_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060045BE RID: 17854
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCAMReader_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045BF RID: 17855 RVA: 0x000657B8 File Offset: 0x000639B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x060045C0 RID: 17856
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFCAMReader_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045C1 RID: 17857 RVA: 0x000657D8 File Offset: 0x000639D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x060045C2 RID: 17858
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetNumberOfPointArrays_16(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045C3 RID: 17859 RVA: 0x000657F4 File Offset: 0x000639F4
		public int GetNumberOfPointArrays()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetNumberOfPointArrays_16(base.GetCppThis());
		}

		// Token: 0x060045C4 RID: 17860
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_GetPointArrayName_17(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045C5 RID: 17861 RVA: 0x00065814 File Offset: 0x00063A14
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetPointArrayName_17(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060045C6 RID: 17862
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetPointArrayStatus_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045C7 RID: 17863 RVA: 0x00065850 File Offset: 0x00063A50
		public int GetPointArrayStatus(string name)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetPointArrayStatus_18(base.GetCppThis(), name);
		}

		// Token: 0x060045C8 RID: 17864
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetSingleInterfaceLayer_19(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045C9 RID: 17865 RVA: 0x00065870 File Offset: 0x00063A70
		public virtual int GetSingleInterfaceLayer()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetSingleInterfaceLayer_19(base.GetCppThis());
		}

		// Token: 0x060045CA RID: 17866
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetSingleMidpointLayer_20(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045CB RID: 17867 RVA: 0x00065890 File Offset: 0x00063A90
		public virtual int GetSingleMidpointLayer()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetSingleMidpointLayer_20(base.GetCppThis());
		}

		// Token: 0x060045CC RID: 17868
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetVerticalDimension_21(HandleRef pThis);

		/// <summary>
		/// Set whether to read a single layer, midpoint layers or interface layers.
		/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
		/// layer will be read in. The NetCDF variables loaded will be the
		/// ones with dimensions (time, ncol).
		/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
		/// on midpoint layers will be read in. These are variables with dimensions
		/// (time, lev, ncol).
		/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
		/// defined on interface layers will be read in. These are variables with
		/// dimensions (time, ilev, ncol).
		/// </summary>
		// Token: 0x060045CD RID: 17869 RVA: 0x000658B0 File Offset: 0x00063AB0
		public virtual int GetVerticalDimension()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetVerticalDimension_21(base.GetCppThis());
		}

		// Token: 0x060045CE RID: 17870
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetVerticalDimensionMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set whether to read a single layer, midpoint layers or interface layers.
		/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
		/// layer will be read in. The NetCDF variables loaded will be the
		/// ones with dimensions (time, ncol).
		/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
		/// on midpoint layers will be read in. These are variables with dimensions
		/// (time, lev, ncol).
		/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
		/// defined on interface layers will be read in. These are variables with
		/// dimensions (time, ilev, ncol).
		/// </summary>
		// Token: 0x060045CF RID: 17871 RVA: 0x000658D0 File Offset: 0x00063AD0
		public virtual int GetVerticalDimensionMaxValue()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetVerticalDimensionMaxValue_22(base.GetCppThis());
		}

		// Token: 0x060045D0 RID: 17872
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_GetVerticalDimensionMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set whether to read a single layer, midpoint layers or interface layers.
		/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
		/// layer will be read in. The NetCDF variables loaded will be the
		/// ones with dimensions (time, ncol).
		/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
		/// on midpoint layers will be read in. These are variables with dimensions
		/// (time, lev, ncol).
		/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
		/// defined on interface layers will be read in. These are variables with
		/// dimensions (time, ilev, ncol).
		/// </summary>
		// Token: 0x060045D1 RID: 17873 RVA: 0x000658F0 File Offset: 0x00063AF0
		public virtual int GetVerticalDimensionMinValue()
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_GetVerticalDimensionMinValue_23(base.GetCppThis());
		}

		// Token: 0x060045D2 RID: 17874
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045D3 RID: 17875 RVA: 0x00065910 File Offset: 0x00063B10
		public override int IsA(string type)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x060045D4 RID: 17876
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFCAMReader_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045D5 RID: 17877 RVA: 0x00065930 File Offset: 0x00063B30
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFCAMReader.vtkNetCDFCAMReader_IsTypeOf_25(type);
		}

		// Token: 0x060045D6 RID: 17878
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045D7 RID: 17879 RVA: 0x0006594C File Offset: 0x00063B4C
		public new vtkNetCDFCAMReader NewInstance()
		{
			vtkNetCDFCAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCAMReader.vtkNetCDFCAMReader_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060045D8 RID: 17880
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFCAMReader_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060045D9 RID: 17881 RVA: 0x000659A8 File Offset: 0x00063BA8
		public new static vtkNetCDFCAMReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFCAMReader vtkNetCDFCAMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFCAMReader.vtkNetCDFCAMReader_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFCAMReader = (vtkNetCDFCAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFCAMReader.Register(null);
				}
			}
			return vtkNetCDFCAMReader;
		}

		// Token: 0x060045DA RID: 17882
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetConnectivityFileName_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because NetCDF CAM files come in pairs and we only check one of the
		/// files, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x060045DB RID: 17883 RVA: 0x00065A27 File Offset: 0x00063C27
		public void SetConnectivityFileName(string fileName)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetConnectivityFileName_29(base.GetCppThis(), fileName);
		}

		// Token: 0x060045DC RID: 17884
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetFileName_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Returns 1 if this file can be read and 0 if the file cannot be read.
		/// Because NetCDF CAM files come in pairs and we only check one of the
		/// files, the result is not definitive.  Invalid files may still return 1
		/// although a valid file will never return 0.
		/// </summary>
		// Token: 0x060045DD RID: 17885 RVA: 0x00065A37 File Offset: 0x00063C37
		public void SetFileName(string fileName)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetFileName_30(base.GetCppThis(), fileName);
		}

		// Token: 0x060045DE RID: 17886
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetInterfaceLayerIndex_31(HandleRef pThis, int _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045DF RID: 17887 RVA: 0x00065A47 File Offset: 0x00063C47
		public virtual void SetInterfaceLayerIndex(int _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetInterfaceLayerIndex_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060045E0 RID: 17888
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetMidpointLayerIndex_32(HandleRef pThis, int _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045E1 RID: 17889 RVA: 0x00065A57 File Offset: 0x00063C57
		public virtual void SetMidpointLayerIndex(int _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetMidpointLayerIndex_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060045E2 RID: 17890
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetPointArrayStatus_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of variables.
		/// By default, ALL data variables on the nodes are read.
		/// </summary>
		// Token: 0x060045E3 RID: 17891 RVA: 0x00065A67 File Offset: 0x00063C67
		public void SetPointArrayStatus(string name, int status)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetPointArrayStatus_33(base.GetCppThis(), name, status);
		}

		// Token: 0x060045E4 RID: 17892
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetSingleInterfaceLayer_34(HandleRef pThis, int _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045E5 RID: 17893 RVA: 0x00065A78 File Offset: 0x00063C78
		public virtual void SetSingleInterfaceLayer(int _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetSingleInterfaceLayer_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060045E6 RID: 17894
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetSingleMidpointLayer_35(HandleRef pThis, int _arg);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045E7 RID: 17895 RVA: 0x00065A88 File Offset: 0x00063C88
		public virtual void SetSingleMidpointLayer(int _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetSingleMidpointLayer_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060045E8 RID: 17896
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SetVerticalDimension_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to read a single layer, midpoint layers or interface layers.
		/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
		/// layer will be read in. The NetCDF variables loaded will be the
		/// ones with dimensions (time, ncol).
		/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
		/// on midpoint layers will be read in. These are variables with dimensions
		/// (time, lev, ncol).
		/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
		/// defined on interface layers will be read in. These are variables with
		/// dimensions (time, ilev, ncol).
		/// </summary>
		// Token: 0x060045E9 RID: 17897 RVA: 0x00065A98 File Offset: 0x00063C98
		public virtual void SetVerticalDimension(int _arg)
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SetVerticalDimension_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060045EA RID: 17898
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SingleInterfaceLayerOff_37(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045EB RID: 17899 RVA: 0x00065AA8 File Offset: 0x00063CA8
		public virtual void SingleInterfaceLayerOff()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SingleInterfaceLayerOff_37(base.GetCppThis());
		}

		// Token: 0x060045EC RID: 17900
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SingleInterfaceLayerOn_38(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045ED RID: 17901 RVA: 0x00065AB7 File Offset: 0x00063CB7
		public virtual void SingleInterfaceLayerOn()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SingleInterfaceLayerOn_38(base.GetCppThis());
		}

		// Token: 0x060045EE RID: 17902
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SingleMidpointLayerOff_39(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045EF RID: 17903 RVA: 0x00065AC6 File Offset: 0x00063CC6
		public virtual void SingleMidpointLayerOff()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SingleMidpointLayerOff_39(base.GetCppThis());
		}

		// Token: 0x060045F0 RID: 17904
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFCAMReader_SingleMidpointLayerOn_40(HandleRef pThis);

		/// <summary>
		/// If SingleXXXLayer is 1, we'll load only the layer specified by
		/// XXXLayerIndex.  Otherwise, we load all layers. We do that for
		/// midpoint layer variables ( which have dimension 'lev') or for
		/// interface layer variables (which have dimension 'ilev').
		/// </summary>
		// Token: 0x060045F1 RID: 17905 RVA: 0x00065AD5 File Offset: 0x00063CD5
		public virtual void SingleMidpointLayerOn()
		{
			vtkNetCDFCAMReader.vtkNetCDFCAMReader_SingleMidpointLayerOn_40(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000724 RID: 1828
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFCAMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000725 RID: 1829
		public new static readonly string MRClassNameKey = "class vtkNetCDFCAMReader";

		/// <summary>
		/// Set whether to read a single layer, midpoint layers or interface layers.
		/// VERTICAL_DIMENSION_SINGLE_LAYER (0) indicates that only a single
		/// layer will be read in. The NetCDF variables loaded will be the
		/// ones with dimensions (time, ncol).
		/// VERTICAL_DIMENSION_MIDPOINT_LAYERS (1) indicates that variables defined
		/// on midpoint layers will be read in. These are variables with dimensions
		/// (time, lev, ncol).
		/// VERTICAL_DIMENSION_INTERFACE_LAYERS (2) indicates that variables
		/// defined on interface layers will be read in. These are variables with
		/// dimensions (time, ilev, ncol).
		/// </summary>
		// Token: 0x0200016D RID: 365
		public enum VerticalDimension
		{
			/// <summary>enum member</summary>
			// Token: 0x04000727 RID: 1831
			VERTICAL_DIMENSION_COUNT = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000728 RID: 1832
			VERTICAL_DIMENSION_INTERFACE_LAYERS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000729 RID: 1833
			VERTICAL_DIMENSION_MIDPOINT_LAYERS = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400072A RID: 1834
			VERTICAL_DIMENSION_SINGLE_LAYER = 0
		}
	}
}
