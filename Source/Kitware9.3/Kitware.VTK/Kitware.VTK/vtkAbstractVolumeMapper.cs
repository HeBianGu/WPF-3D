using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractVolumeMapper
	/// </summary>
	/// <remarks>
	///    Abstract class for a volume mapper
	///
	///
	/// vtkAbstractVolumeMapper is the abstract definition of a volume mapper.
	/// Specific subclasses deal with different specific types of data input
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVolumeMapper vtkUnstructuredGridVolumeMapper
	/// </seealso>
	// Token: 0x020000CC RID: 204
	public abstract class vtkAbstractVolumeMapper : vtkAbstractMapper3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002B8A RID: 11146 RVA: 0x0004067B File Offset: 0x0003E87B
		static vtkAbstractVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002B8B RID: 11147 RVA: 0x000406A3 File Offset: 0x0003E8A3
		public vtkAbstractVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002B8C RID: 11148 RVA: 0x000406B1 File Offset: 0x0003E8B1
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002B8D RID: 11149
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractVolumeMapper_GetArrayAccessMode_01(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to use for rendering.
		/// </summary>
		// Token: 0x06002B8E RID: 11150 RVA: 0x000406BC File Offset: 0x0003E8BC
		public virtual int GetArrayAccessMode()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayAccessMode_01(base.GetCppThis());
		}

		// Token: 0x06002B8F RID: 11151
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractVolumeMapper_GetArrayId_02(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to use for rendering.
		/// </summary>
		// Token: 0x06002B90 RID: 11152 RVA: 0x000406DC File Offset: 0x0003E8DC
		public virtual int GetArrayId()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayId_02(base.GetCppThis());
		}

		// Token: 0x06002B91 RID: 11153
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetArrayName_03(HandleRef pThis);

		/// <summary>
		/// Get the array name or number and component to use for rendering.
		/// </summary>
		// Token: 0x06002B92 RID: 11154 RVA: 0x000406FC File Offset: 0x0003E8FC
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002B93 RID: 11155
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetBounds_04(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06002B94 RID: 11156 RVA: 0x00040738 File Offset: 0x0003E938
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002B95 RID: 11157
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06002B96 RID: 11158 RVA: 0x00040780 File Offset: 0x0003E980
		public override void GetBounds(IntPtr bounds)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x06002B97 RID: 11159
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetDataObjectInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002B98 RID: 11160 RVA: 0x00040790 File Offset: 0x0003E990
		public virtual vtkDataObject GetDataObjectInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetDataObjectInput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002B99 RID: 11161
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetDataSetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002B9A RID: 11162 RVA: 0x00040800 File Offset: 0x0003EA00
		public virtual vtkDataSet GetDataSetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetDataSetInput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06002B9B RID: 11163
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002B9C RID: 11164 RVA: 0x00040870 File Offset: 0x0003EA70
		public virtual float GetGradientMagnitudeBias()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeBias_08(base.GetCppThis());
		}

		// Token: 0x06002B9D RID: 11165
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002B9E RID: 11166 RVA: 0x00040890 File Offset: 0x0003EA90
		public virtual float GetGradientMagnitudeBias(int arg0)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeBias_09(base.GetCppThis(), arg0);
		}

		// Token: 0x06002B9F RID: 11167
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002BA0 RID: 11168 RVA: 0x000408B0 File Offset: 0x0003EAB0
		public virtual float GetGradientMagnitudeScale()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeScale_10(base.GetCppThis());
		}

		// Token: 0x06002BA1 RID: 11169
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(HandleRef pThis, int arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// </summary>
		// Token: 0x06002BA2 RID: 11170 RVA: 0x000408D0 File Offset: 0x0003EAD0
		public virtual float GetGradientMagnitudeScale(int arg0)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetGradientMagnitudeScale_11(base.GetCppThis(), arg0);
		}

		// Token: 0x06002BA3 RID: 11171
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BA4 RID: 11172 RVA: 0x000408F0 File Offset: 0x0003EAF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06002BA5 RID: 11173
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BA6 RID: 11174 RVA: 0x00040910 File Offset: 0x0003EB10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06002BA7 RID: 11175
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractVolumeMapper_GetScalarMode_14(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BA8 RID: 11176 RVA: 0x0004092C File Offset: 0x0003EB2C
		public virtual int GetScalarMode()
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetScalarMode_14(base.GetCppThis());
		}

		// Token: 0x06002BA9 RID: 11177
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_GetScalarModeAsString_15(HandleRef pThis);

		/// <summary>
		/// Return the method for obtaining scalar data.
		/// </summary>
		// Token: 0x06002BAA RID: 11178 RVA: 0x0004094C File Offset: 0x0003EB4C
		public string GetScalarModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_GetScalarModeAsString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002BAB RID: 11179
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractVolumeMapper_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BAC RID: 11180 RVA: 0x00040988 File Offset: 0x0003EB88
		public override int IsA(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06002BAD RID: 11181
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractVolumeMapper_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BAE RID: 11182 RVA: 0x000409A8 File Offset: 0x0003EBA8
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_IsTypeOf_17(type);
		}

		// Token: 0x06002BAF RID: 11183
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BB0 RID: 11184 RVA: 0x000409C4 File Offset: 0x0003EBC4
		public new vtkAbstractVolumeMapper NewInstance()
		{
			vtkAbstractVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002BB1 RID: 11185
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002BB2 RID: 11186 RVA: 0x00040A20 File Offset: 0x0003EC20
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_ReleaseGraphicsResources_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002BB3 RID: 11187
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_Render_20(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x06002BB4 RID: 11188 RVA: 0x00040A50 File Offset: 0x0003EC50
		public virtual void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_Render_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x06002BB5 RID: 11189
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractVolumeMapper_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BB6 RID: 11190 RVA: 0x00040A94 File Offset: 0x0003EC94
		public new static vtkAbstractVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractVolumeMapper vtkAbstractVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractVolumeMapper = (vtkAbstractVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractVolumeMapper.Register(null);
				}
			}
			return vtkAbstractVolumeMapper;
		}

		// Token: 0x06002BB7 RID: 11191
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_22(HandleRef pThis, int arrayNum);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which scalar array to use during rendering.
		/// The transfer function in the vtkVolumeProperty (attached to the calling
		/// vtkVolume) will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06002BB8 RID: 11192 RVA: 0x00040B13 File Offset: 0x0003ED13
		public virtual void SelectScalarArray(int arrayNum)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SelectScalarArray_22(base.GetCppThis(), arrayNum);
		}

		// Token: 0x06002BB9 RID: 11193
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SelectScalarArray_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// When ScalarMode is set to UsePointFieldData or UseCellFieldData,
		/// you can specify which scalar array to use during rendering.
		/// The transfer function in the vtkVolumeProperty (attached to the calling
		/// vtkVolume) will decide how to convert vectors to colors.
		/// </summary>
		// Token: 0x06002BBA RID: 11194 RVA: 0x00040B23 File Offset: 0x0003ED23
		public virtual void SelectScalarArray(string arrayName)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SelectScalarArray_23(base.GetCppThis(), arrayName);
		}

		// Token: 0x06002BBB RID: 11195
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetArrayAccessMode_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BBC RID: 11196 RVA: 0x00040B33 File Offset: 0x0003ED33
		public virtual void SetArrayAccessMode(int _arg)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetArrayAccessMode_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06002BBD RID: 11197
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarMode_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BBE RID: 11198 RVA: 0x00040B43 File Offset: 0x0003ED43
		public virtual void SetScalarMode(int _arg)
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarMode_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06002BBF RID: 11199
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToDefault_26(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BC0 RID: 11200 RVA: 0x00040B53 File Offset: 0x0003ED53
		public void SetScalarModeToDefault()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToDefault_26(base.GetCppThis());
		}

		// Token: 0x06002BC1 RID: 11201
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellData_27(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BC2 RID: 11202 RVA: 0x00040B62 File Offset: 0x0003ED62
		public void SetScalarModeToUseCellData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUseCellData_27(base.GetCppThis());
		}

		// Token: 0x06002BC3 RID: 11203
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_28(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BC4 RID: 11204 RVA: 0x00040B71 File Offset: 0x0003ED71
		public void SetScalarModeToUseCellFieldData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUseCellFieldData_28(base.GetCppThis());
		}

		// Token: 0x06002BC5 RID: 11205
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointData_29(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BC6 RID: 11206 RVA: 0x00040B80 File Offset: 0x0003ED80
		public void SetScalarModeToUsePointData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUsePointData_29(base.GetCppThis());
		}

		// Token: 0x06002BC7 RID: 11207
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_30(HandleRef pThis);

		/// <summary>
		/// Control how the mapper works with scalar point data and cell attribute
		/// data.  By default (ScalarModeToDefault), the mapper will use point data,
		/// and if no point data is available, then cell data is used. Alternatively
		/// you can explicitly set the mapper to use point data
		/// (ScalarModeToUsePointData) or cell data (ScalarModeToUseCellData).
		/// You can also choose to get the scalars from an array in point field
		/// data (ScalarModeToUsePointFieldData) or cell field data
		/// (ScalarModeToUseCellFieldData).  If scalars are coming from a field
		/// data array, you must call SelectScalarArray.
		/// </summary>
		// Token: 0x06002BC8 RID: 11208 RVA: 0x00040B8F File Offset: 0x0003ED8F
		public void SetScalarModeToUsePointFieldData()
		{
			vtkAbstractVolumeMapper.vtkAbstractVolumeMapper_SetScalarModeToUsePointFieldData_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400058A RID: 1418
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400058B RID: 1419
		public new static readonly string MRClassNameKey = "class vtkAbstractVolumeMapper";
	}
}
