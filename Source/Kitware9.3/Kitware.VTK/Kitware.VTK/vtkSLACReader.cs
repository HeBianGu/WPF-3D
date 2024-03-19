using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSLACReader
	///
	///
	///
	/// A reader for a data format used by Omega3p, Tau3p, and several other tools
	/// used at the Standford Linear Accelerator Center (SLAC).  The underlying
	/// format uses netCDF to store arrays, but also imposes several conventions
	/// to form an unstructured grid of elements.
	///
	/// </summary>
	// Token: 0x02000175 RID: 373
	public class vtkSLACReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004722 RID: 18210 RVA: 0x00067783 File Offset: 0x00065983
		static vtkSLACReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLACReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004723 RID: 18211 RVA: 0x000677AB File Offset: 0x000659AB
		public vtkSLACReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004724 RID: 18212
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004725 RID: 18213 RVA: 0x000677BC File Offset: 0x000659BC
		public new static vtkSLACReader New()
		{
			vtkSLACReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004726 RID: 18214 RVA: 0x00067810 File Offset: 0x00065A10
		public vtkSLACReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSLACReader.vtkSLACReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004727 RID: 18215 RVA: 0x00067854 File Offset: 0x00065A54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004728 RID: 18216
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_AddModeFileName_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// There may be one mode file (usually for actual modes) or multiple mode
		/// files (which usually actually represent time series).  These methods
		/// set and clear the list of mode files (which can be a single mode file).
		/// </summary>
		// Token: 0x06004729 RID: 18217 RVA: 0x0006785F File Offset: 0x00065A5F
		public virtual void AddModeFileName(string fname)
		{
			vtkSLACReader.vtkSLACReader_AddModeFileName_01(base.GetCppThis(), fname);
		}

		// Token: 0x0600472A RID: 18218
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_CanReadFile_02([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Returns true if the given file can be read by this reader.
		/// </summary>
		// Token: 0x0600472B RID: 18219 RVA: 0x00067870 File Offset: 0x00065A70
		public static int CanReadFile(string filename)
		{
			return vtkSLACReader.vtkSLACReader_CanReadFile_02(filename);
		}

		// Token: 0x0600472C RID: 18220
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_GetFrequencyScales_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// NOTE: This is not thread-safe.
		/// </summary>
		// Token: 0x0600472D RID: 18221 RVA: 0x0006788C File Offset: 0x00065A8C
		public virtual vtkDoubleArray GetFrequencyScales()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_GetFrequencyScales_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0600472E RID: 18222
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_GetMeshFileName_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600472F RID: 18223 RVA: 0x000678FC File Offset: 0x00065AFC
		public virtual string GetMeshFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetMeshFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004730 RID: 18224
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_GetModeFileName_05(HandleRef pThis, uint idx);

		/// <summary>
		/// There may be one mode file (usually for actual modes) or multiple mode
		/// files (which usually actually represent time series).  These methods
		/// set and clear the list of mode files (which can be a single mode file).
		/// </summary>
		// Token: 0x06004731 RID: 18225 RVA: 0x00067938 File Offset: 0x00065B38
		public virtual string GetModeFileName(uint idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetModeFileName_05(base.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004732 RID: 18226
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLACReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004733 RID: 18227 RVA: 0x00067974 File Offset: 0x00065B74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004734 RID: 18228
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLACReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004735 RID: 18229 RVA: 0x00067994 File Offset: 0x00065B94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004736 RID: 18230
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkSLACReader_GetNumberOfModeFileNames_08(HandleRef pThis);

		/// <summary>
		/// There may be one mode file (usually for actual modes) or multiple mode
		/// files (which usually actually represent time series).  These methods
		/// set and clear the list of mode files (which can be a single mode file).
		/// </summary>
		// Token: 0x06004737 RID: 18231 RVA: 0x000679B0 File Offset: 0x00065BB0
		public virtual uint GetNumberOfModeFileNames()
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfModeFileNames_08(base.GetCppThis());
		}

		// Token: 0x06004738 RID: 18232
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_GetNumberOfVariableArrays_09(HandleRef pThis);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004739 RID: 18233 RVA: 0x000679D0 File Offset: 0x00065BD0
		public virtual int GetNumberOfVariableArrays()
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfVariableArrays_09(base.GetCppThis());
		}

		// Token: 0x0600473A RID: 18234
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_GetPhaseShifts_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// NOTE: This is not thread-safe.
		/// </summary>
		// Token: 0x0600473B RID: 18235 RVA: 0x000679F0 File Offset: 0x00065BF0
		public virtual vtkDoubleArray GetPhaseShifts()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_GetPhaseShifts_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x0600473C RID: 18236
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_GetReadExternalSurface_11(HandleRef pThis);

		/// <summary>
		/// If on, reads the external surfaces of the data set.  Set to on by default.
		/// </summary>
		// Token: 0x0600473D RID: 18237 RVA: 0x00067A60 File Offset: 0x00065C60
		public virtual int GetReadExternalSurface()
		{
			return vtkSLACReader.vtkSLACReader_GetReadExternalSurface_11(base.GetCppThis());
		}

		// Token: 0x0600473E RID: 18238
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_GetReadInternalVolume_12(HandleRef pThis);

		/// <summary>
		/// If on, reads the internal volume of the data set.  Set to off by default.
		/// </summary>
		// Token: 0x0600473F RID: 18239 RVA: 0x00067A80 File Offset: 0x00065C80
		public virtual int GetReadInternalVolume()
		{
			return vtkSLACReader.vtkSLACReader_GetReadInternalVolume_12(base.GetCppThis());
		}

		// Token: 0x06004740 RID: 18240
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_GetReadMidpoints_13(HandleRef pThis);

		/// <summary>
		/// If on, reads midpoint information for external surfaces and builds
		/// quadratic surface triangles.  Set to on by default.
		/// </summary>
		// Token: 0x06004741 RID: 18241 RVA: 0x00067AA0 File Offset: 0x00065CA0
		public virtual int GetReadMidpoints()
		{
			return vtkSLACReader.vtkSLACReader_GetReadMidpoints_13(base.GetCppThis());
		}

		// Token: 0x06004742 RID: 18242
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_GetVariableArrayName_14(HandleRef pThis, int index);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004743 RID: 18243 RVA: 0x00067AC0 File Offset: 0x00065CC0
		public virtual string GetVariableArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetVariableArrayName_14(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004744 RID: 18244
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_GetVariableArrayStatus_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004745 RID: 18245 RVA: 0x00067AFC File Offset: 0x00065CFC
		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkSLACReader.vtkSLACReader_GetVariableArrayStatus_15(base.GetCppThis(), name);
		}

		// Token: 0x06004746 RID: 18246
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_IS_EXTERNAL_SURFACE_16(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is attached to the metadata information of all data sets in the
		/// output that are part of the external surface.
		/// </summary>
		// Token: 0x06004747 RID: 18247 RVA: 0x00067B1C File Offset: 0x00065D1C
		public static vtkInformationIntegerKey IS_EXTERNAL_SURFACE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_IS_EXTERNAL_SURFACE_16(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06004748 RID: 18248
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_IS_INTERNAL_VOLUME_17(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is attached to the metadata information of all data sets in the
		/// output that are part of the internal volume.
		/// </summary>
		// Token: 0x06004749 RID: 18249 RVA: 0x00067B88 File Offset: 0x00065D88
		public static vtkInformationIntegerKey IS_INTERNAL_VOLUME()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_IS_INTERNAL_VOLUME_17(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0600474A RID: 18250
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600474B RID: 18251 RVA: 0x00067BF4 File Offset: 0x00065DF4
		public override int IsA(string type)
		{
			return vtkSLACReader.vtkSLACReader_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600474C RID: 18252
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACReader_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600474D RID: 18253 RVA: 0x00067C14 File Offset: 0x00065E14
		public new static int IsTypeOf(string type)
		{
			return vtkSLACReader.vtkSLACReader_IsTypeOf_19(type);
		}

		// Token: 0x0600474E RID: 18254
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600474F RID: 18255 RVA: 0x00067C30 File Offset: 0x00065E30
		public new vtkSLACReader NewInstance()
		{
			vtkSLACReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004750 RID: 18256
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_POINTS_22(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// All the data sets stored in the multiblock output share the same point
		/// data.  For convenience, the point coordinates (vtkPoints) and point data
		/// (vtkPointData) are saved under these keys in the vtkInformation of the
		/// output data set.
		/// </summary>
		// Token: 0x06004751 RID: 18257 RVA: 0x00067C8C File Offset: 0x00065E8C
		public static vtkInformationObjectBaseKey POINTS()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_POINTS_22(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x06004752 RID: 18258
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_POINT_DATA_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// All the data sets stored in the multiblock output share the same point
		/// data.  For convenience, the point coordinates (vtkPoints) and point data
		/// (vtkPointData) are saved under these keys in the vtkInformation of the
		/// output data set.
		/// </summary>
		// Token: 0x06004753 RID: 18259 RVA: 0x00067CF8 File Offset: 0x00065EF8
		public static vtkInformationObjectBaseKey POINT_DATA()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_POINT_DATA_23(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		// Token: 0x06004754 RID: 18260
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadExternalSurfaceOff_24(HandleRef pThis);

		/// <summary>
		/// If on, reads the external surfaces of the data set.  Set to on by default.
		/// </summary>
		// Token: 0x06004755 RID: 18261 RVA: 0x00067D61 File Offset: 0x00065F61
		public virtual void ReadExternalSurfaceOff()
		{
			vtkSLACReader.vtkSLACReader_ReadExternalSurfaceOff_24(base.GetCppThis());
		}

		// Token: 0x06004756 RID: 18262
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadExternalSurfaceOn_25(HandleRef pThis);

		/// <summary>
		/// If on, reads the external surfaces of the data set.  Set to on by default.
		/// </summary>
		// Token: 0x06004757 RID: 18263 RVA: 0x00067D70 File Offset: 0x00065F70
		public virtual void ReadExternalSurfaceOn()
		{
			vtkSLACReader.vtkSLACReader_ReadExternalSurfaceOn_25(base.GetCppThis());
		}

		// Token: 0x06004758 RID: 18264
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadInternalVolumeOff_26(HandleRef pThis);

		/// <summary>
		/// If on, reads the internal volume of the data set.  Set to off by default.
		/// </summary>
		// Token: 0x06004759 RID: 18265 RVA: 0x00067D7F File Offset: 0x00065F7F
		public virtual void ReadInternalVolumeOff()
		{
			vtkSLACReader.vtkSLACReader_ReadInternalVolumeOff_26(base.GetCppThis());
		}

		// Token: 0x0600475A RID: 18266
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadInternalVolumeOn_27(HandleRef pThis);

		/// <summary>
		/// If on, reads the internal volume of the data set.  Set to off by default.
		/// </summary>
		// Token: 0x0600475B RID: 18267 RVA: 0x00067D8E File Offset: 0x00065F8E
		public virtual void ReadInternalVolumeOn()
		{
			vtkSLACReader.vtkSLACReader_ReadInternalVolumeOn_27(base.GetCppThis());
		}

		// Token: 0x0600475C RID: 18268
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadMidpointsOff_28(HandleRef pThis);

		/// <summary>
		/// If on, reads midpoint information for external surfaces and builds
		/// quadratic surface triangles.  Set to on by default.
		/// </summary>
		// Token: 0x0600475D RID: 18269 RVA: 0x00067D9D File Offset: 0x00065F9D
		public virtual void ReadMidpointsOff()
		{
			vtkSLACReader.vtkSLACReader_ReadMidpointsOff_28(base.GetCppThis());
		}

		// Token: 0x0600475E RID: 18270
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ReadMidpointsOn_29(HandleRef pThis);

		/// <summary>
		/// If on, reads midpoint information for external surfaces and builds
		/// quadratic surface triangles.  Set to on by default.
		/// </summary>
		// Token: 0x0600475F RID: 18271 RVA: 0x00067DAC File Offset: 0x00065FAC
		public virtual void ReadMidpointsOn()
		{
			vtkSLACReader.vtkSLACReader_ReadMidpointsOn_29(base.GetCppThis());
		}

		// Token: 0x06004760 RID: 18272
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_RemoveAllModeFileNames_30(HandleRef pThis);

		/// <summary>
		/// There may be one mode file (usually for actual modes) or multiple mode
		/// files (which usually actually represent time series).  These methods
		/// set and clear the list of mode files (which can be a single mode file).
		/// </summary>
		// Token: 0x06004761 RID: 18273 RVA: 0x00067DBB File Offset: 0x00065FBB
		public virtual void RemoveAllModeFileNames()
		{
			vtkSLACReader.vtkSLACReader_RemoveAllModeFileNames_30(base.GetCppThis());
		}

		// Token: 0x06004762 RID: 18274
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ResetFrequencyScales_31(HandleRef pThis);

		/// <summary>
		/// Sets the scale factor for each mode. Each scale factor is reset to 1.
		/// </summary>
		// Token: 0x06004763 RID: 18275 RVA: 0x00067DCA File Offset: 0x00065FCA
		public virtual void ResetFrequencyScales()
		{
			vtkSLACReader.vtkSLACReader_ResetFrequencyScales_31(base.GetCppThis());
		}

		// Token: 0x06004764 RID: 18276
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_ResetPhaseShifts_32(HandleRef pThis);

		/// <summary>
		/// Sets the phase offset for each mode. Each shift is reset to 0.
		/// </summary>
		// Token: 0x06004765 RID: 18277 RVA: 0x00067DD9 File Offset: 0x00065FD9
		public virtual void ResetPhaseShifts()
		{
			vtkSLACReader.vtkSLACReader_ResetPhaseShifts_32(base.GetCppThis());
		}

		// Token: 0x06004766 RID: 18278
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACReader_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004767 RID: 18279 RVA: 0x00067DE8 File Offset: 0x00065FE8
		public new static vtkSLACReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLACReader vtkSLACReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLACReader = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLACReader.Register(null);
				}
			}
			return vtkSLACReader;
		}

		// Token: 0x06004768 RID: 18280
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetFrequencyScale_34(HandleRef pThis, int index, double scale);

		/// <summary>
		/// Sets the scale factor for each mode. Each scale factor is reset to 1.
		/// </summary>
		// Token: 0x06004769 RID: 18281 RVA: 0x00067E67 File Offset: 0x00066067
		public virtual void SetFrequencyScale(int index, double scale)
		{
			vtkSLACReader.vtkSLACReader_SetFrequencyScale_34(base.GetCppThis(), index, scale);
		}

		// Token: 0x0600476A RID: 18282
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetMeshFileName_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600476B RID: 18283 RVA: 0x00067E78 File Offset: 0x00066078
		public virtual void SetMeshFileName(string _arg)
		{
			vtkSLACReader.vtkSLACReader_SetMeshFileName_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600476C RID: 18284
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetPhaseShift_36(HandleRef pThis, int index, double shift);

		/// <summary>
		/// Sets the phase offset for each mode. Each shift is reset to 0.
		/// </summary>
		// Token: 0x0600476D RID: 18285 RVA: 0x00067E88 File Offset: 0x00066088
		public virtual void SetPhaseShift(int index, double shift)
		{
			vtkSLACReader.vtkSLACReader_SetPhaseShift_36(base.GetCppThis(), index, shift);
		}

		// Token: 0x0600476E RID: 18286
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetReadExternalSurface_37(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, reads the external surfaces of the data set.  Set to on by default.
		/// </summary>
		// Token: 0x0600476F RID: 18287 RVA: 0x00067E99 File Offset: 0x00066099
		public virtual void SetReadExternalSurface(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadExternalSurface_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06004770 RID: 18288
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetReadInternalVolume_38(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, reads the internal volume of the data set.  Set to off by default.
		/// </summary>
		// Token: 0x06004771 RID: 18289 RVA: 0x00067EA9 File Offset: 0x000660A9
		public virtual void SetReadInternalVolume(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadInternalVolume_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06004772 RID: 18290
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetReadMidpoints_39(HandleRef pThis, int _arg);

		/// <summary>
		/// If on, reads midpoint information for external surfaces and builds
		/// quadratic surface triangles.  Set to on by default.
		/// </summary>
		// Token: 0x06004773 RID: 18291 RVA: 0x00067EB9 File Offset: 0x000660B9
		public virtual void SetReadMidpoints(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadMidpoints_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06004774 RID: 18292
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACReader_SetVariableArrayStatus_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x06004775 RID: 18293 RVA: 0x00067EC9 File Offset: 0x000660C9
		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkSLACReader.vtkSLACReader_SetVariableArrayStatus_40(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000739 RID: 1849
		public new const string MRFullTypeName = "Kitware.VTK.vtkSLACReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400073A RID: 1850
		public new static readonly string MRClassNameKey = "class vtkSLACReader";

		/// <summary>
		/// Simple class used internally for holding midpoint information.
		/// </summary>
		// Token: 0x02000176 RID: 374
		public enum NUM_OUTPUTS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400073C RID: 1852
			NUM_OUTPUTS = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400073D RID: 1853
			SURFACE_OUTPUT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400073E RID: 1854
			VOLUME_OUTPUT
		}
	}
}
