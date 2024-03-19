using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGlyph3DMapper
	/// </summary>
	/// <remarks>
	///    vtkGlyph3D on the GPU.
	///
	/// Do the same job than vtkGlyph3D but on the GPU. For this reason, it is
	/// a mapper not a vtkPolyDataAlgorithm. Also, some methods of vtkGlyph3D
	/// don't make sense in vtkGlyph3DMapper: GeneratePointIds, old-style
	/// SetSource, PointIdsName, IsPointVisible.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGlyph3D
	/// </seealso>
	// Token: 0x020005AA RID: 1450
	public class vtkGlyph3DMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FE4A RID: 65098 RVA: 0x001620B7 File Offset: 0x001602B7
		static vtkGlyph3DMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph3DMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph3DMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FE4B RID: 65099 RVA: 0x001620DF File Offset: 0x001602DF
		public vtkGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FE4C RID: 65100
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE4D RID: 65101 RVA: 0x001620F0 File Offset: 0x001602F0
		public new static vtkGlyph3DMapper New()
		{
			vtkGlyph3DMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE4E RID: 65102 RVA: 0x00162144 File Offset: 0x00160344
		public vtkGlyph3DMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGlyph3DMapper.vtkGlyph3DMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FE4F RID: 65103 RVA: 0x00162188 File Offset: 0x00160388
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FE50 RID: 65104
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_ClampingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of data values to scale with to the specified range.
		/// </summary>
		// Token: 0x0600FE51 RID: 65105 RVA: 0x00162193 File Offset: 0x00160393
		public virtual void ClampingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ClampingOff_01(base.GetCppThis());
		}

		// Token: 0x0600FE52 RID: 65106
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_ClampingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of data values to scale with to the specified range.
		/// </summary>
		// Token: 0x0600FE53 RID: 65107 RVA: 0x001621A2 File Offset: 0x001603A2
		public virtual void ClampingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ClampingOn_02(base.GetCppThis());
		}

		// Token: 0x0600FE54 RID: 65108
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetBlockAttributes_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When the input data object (not the source) is composite data,
		/// it is possible to control visibility and pickability on a per-block
		/// basis by passing the mapper a vtkCompositeDataDisplayAttributes instance.
		/// The color and opacity in the display-attributes instance are ignored
		/// for now. By default, the mapper does not own a display-attributes
		/// instance. The value of BlockAttributes has no effect when the input
		/// is a poly-data object.
		/// </summary>
		// Token: 0x0600FE55 RID: 65109 RVA: 0x001621B4 File Offset: 0x001603B4
		public virtual vtkCompositeDataDisplayAttributes GetBlockAttributes()
		{
			vtkCompositeDataDisplayAttributes vtkCompositeDataDisplayAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetBlockAttributes_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataDisplayAttributes = (vtkCompositeDataDisplayAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataDisplayAttributes.Register(null);
				}
			}
			return vtkCompositeDataDisplayAttributes;
		}

		// Token: 0x0600FE56 RID: 65110
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetBounds_04(HandleRef pThis);

		/// <summary>
		/// Redefined to take into account the bounds of the scaled glyphs.
		/// </summary>
		// Token: 0x0600FE57 RID: 65111 RVA: 0x00162224 File Offset: 0x00160424
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FE58 RID: 65112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Same as superclass. Appear again to stop warnings about hidden method.
		/// </summary>
		// Token: 0x0600FE59 RID: 65113 RVA: 0x0016226C File Offset: 0x0016046C
		public override void GetBounds(IntPtr bounds)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x0600FE5A RID: 65114
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetClamping_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off clamping of data values to scale with to the specified range.
		/// </summary>
		// Token: 0x0600FE5B RID: 65115 RVA: 0x0016227C File Offset: 0x0016047C
		public virtual bool GetClamping()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetClamping_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE5C RID: 65116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetCullingAndLOD_07(HandleRef pThis);

		/// <summary>
		/// Enable or disable frustum culling and LOD of the instances.
		/// When enabled, an OpenGL driver supporting GL_ARB_gpu_shader5 extension is mandatory.
		/// </summary>
		// Token: 0x0600FE5D RID: 65117 RVA: 0x001622A4 File Offset: 0x001604A4
		public virtual bool GetCullingAndLOD()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetCullingAndLOD_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE5E RID: 65118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetLODColoring_08(HandleRef pThis);

		/// <summary>
		/// Enable LOD coloring. It can be useful to configure properly the LODs.
		/// Each LOD have a unique color, based on its index.
		/// </summary>
		// Token: 0x0600FE5F RID: 65119 RVA: 0x001622CC File Offset: 0x001604CC
		public virtual bool GetLODColoring()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetLODColoring_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE60 RID: 65120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetMasking_09(HandleRef pThis);

		/// <summary>
		/// Tells the mapper to skip glyphing input points that haves false values
		/// in the mask array. If there is no mask array (id access mode is set
		/// and there is no such id, or array name access mode is set and
		/// the there is no such name), masking is silently ignored.
		/// A mask array is a vtkBitArray with only one component.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FE61 RID: 65121 RVA: 0x001622F4 File Offset: 0x001604F4
		public virtual bool GetMasking()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetMasking_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE62 RID: 65122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph3DMapper_GetMaxNumberOfLOD_10(HandleRef pThis);

		/// <summary>
		/// Get the maximum number of LOD. OpenGL context must be bound.
		/// The maximum number of LOD depends on GPU capabilities.
		/// This method is intended to be reimplemented in inherited classes, current implementation
		/// always returns zero.
		/// </summary>
		// Token: 0x0600FE63 RID: 65123 RVA: 0x0016231C File Offset: 0x0016051C
		public virtual long GetMaxNumberOfLOD()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetMaxNumberOfLOD_10(base.GetCppThis());
		}

		// Token: 0x0600FE64 RID: 65124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph3DMapper_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE65 RID: 65125 RVA: 0x0016233C File Offset: 0x0016053C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600FE66 RID: 65126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph3DMapper_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE67 RID: 65127 RVA: 0x0016235C File Offset: 0x0016055C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600FE68 RID: 65128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetOrient_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry.
		/// When turned on, the orientation array specified
		/// using SetOrientationArray() will be used.
		/// </summary>
		// Token: 0x0600FE69 RID: 65129 RVA: 0x00162378 File Offset: 0x00160578
		public virtual bool GetOrient()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrient_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE6A RID: 65130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_GetOrientationMode_14(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FE6B RID: 65131 RVA: 0x001623A0 File Offset: 0x001605A0
		public virtual int GetOrientationMode()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationMode_14(base.GetCppThis());
		}

		// Token: 0x0600FE6C RID: 65132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetOrientationModeAsString_15(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FE6D RID: 65133 RVA: 0x001623C0 File Offset: 0x001605C0
		public string GetOrientationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeAsString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600FE6E RID: 65134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_GetOrientationModeMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FE6F RID: 65135 RVA: 0x001623FC File Offset: 0x001605FC
		public virtual int GetOrientationModeMaxValue()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600FE70 RID: 65136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_GetOrientationModeMinValue_17(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FE71 RID: 65137 RVA: 0x0016241C File Offset: 0x0016061C
		public virtual int GetOrientationModeMinValue()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetOrientationModeMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600FE72 RID: 65138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetRange_18(HandleRef pThis);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600FE73 RID: 65139 RVA: 0x0016243C File Offset: 0x0016063C
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetRange_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FE74 RID: 65140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_GetRange_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600FE75 RID: 65141 RVA: 0x00162484 File Offset: 0x00160684
		public virtual void GetRange(IntPtr data)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_GetRange_19(base.GetCppThis(), data);
		}

		// Token: 0x0600FE76 RID: 65142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGlyph3DMapper_GetScaleFactor_20(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FE77 RID: 65143 RVA: 0x00162494 File Offset: 0x00160694
		public virtual double GetScaleFactor()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleFactor_20(base.GetCppThis());
		}

		// Token: 0x0600FE78 RID: 65144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_GetScaleMode_21(HandleRef pThis);

		/// <summary>
		/// Either scale by individual components (SCALE_BY_COMPONENTS) or magnitude
		/// (SCALE_BY_MAGNITUDE) of the chosen array to SCALE with or disable scaling
		/// using data array all together (NO_DATA_SCALING). Default is
		/// NO_DATA_SCALING.
		/// </summary>
		// Token: 0x0600FE79 RID: 65145 RVA: 0x001624B4 File Offset: 0x001606B4
		public virtual int GetScaleMode()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleMode_21(base.GetCppThis());
		}

		// Token: 0x0600FE7A RID: 65146
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetScaleModeAsString_22(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FE7B RID: 65147 RVA: 0x001624D4 File Offset: 0x001606D4
		public string GetScaleModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaleModeAsString_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600FE7C RID: 65148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetScaling_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
		/// controls the scale applied. To scale with some data array, ScaleMode should
		/// be set accordingly.
		/// </summary>
		// Token: 0x0600FE7D RID: 65149 RVA: 0x00162510 File Offset: 0x00160710
		public virtual bool GetScaling()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetScaling_23(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE7E RID: 65150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGlyph3DMapper_GetSelectionColorId_24(HandleRef pThis);

		/// <summary>
		/// For selection by color id mode (not for end-user, called by
		/// vtkGlyphSelectionRenderMode). 0 is reserved for miss. it has to
		/// start at 1. Initial value is 1.
		/// </summary>
		// Token: 0x0600FE7F RID: 65151 RVA: 0x00162538 File Offset: 0x00160738
		public virtual uint GetSelectionColorId()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSelectionColorId_24(base.GetCppThis());
		}

		// Token: 0x0600FE80 RID: 65152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetSource_25(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to a source object at a specified table location.
		/// </summary>
		// Token: 0x0600FE81 RID: 65153 RVA: 0x00162558 File Offset: 0x00160758
		public vtkPolyData GetSource(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetSource_25(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600FE82 RID: 65154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetSourceIndexing_26(HandleRef pThis);

		/// <summary>
		/// Enable/disable indexing into table of the glyph sources. When disabled,
		/// only the 1st source input will be used to generate the glyph. Otherwise the
		/// source index array will be used to select the glyph source. The source
		/// index array can be specified using SetSourceIndexArray().
		/// </summary>
		// Token: 0x0600FE83 RID: 65155 RVA: 0x001625C8 File Offset: 0x001607C8
		public virtual bool GetSourceIndexing()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSourceIndexing_26(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE84 RID: 65156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_GetSourceTableTree_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the source table tree, if it exists.
		/// </summary>
		// Token: 0x0600FE85 RID: 65157 RVA: 0x001625F0 File Offset: 0x001607F0
		public vtkDataObjectTree GetSourceTableTree()
		{
			vtkDataObjectTree vtkDataObjectTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_GetSourceTableTree_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTree = (vtkDataObjectTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTree.Register(null);
				}
			}
			return vtkDataObjectTree;
		}

		// Token: 0x0600FE86 RID: 65158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetSupportsSelection_28(HandleRef pThis);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Used by vtkHardwareSelector to determine if the prop supports hardware
		/// selection.
		/// </summary>
		// Token: 0x0600FE87 RID: 65159 RVA: 0x00162660 File Offset: 0x00160860
		public override bool GetSupportsSelection()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetSupportsSelection_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE88 RID: 65160
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetUseSelectionIds_29(HandleRef pThis);

		/// <summary>
		/// Turn on/off custom selection ids. If enabled, the id values set with
		/// SetSelectionIdArray are returned from pick events.
		/// </summary>
		// Token: 0x0600FE89 RID: 65161 RVA: 0x00162688 File Offset: 0x00160888
		public virtual bool GetUseSelectionIds()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetUseSelectionIds_29(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE8A RID: 65162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGlyph3DMapper_GetUseSourceTableTree_30(HandleRef pThis);

		/// <summary>
		/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
		/// the top-level members of the tree will be mapped to the glyph source table
		/// used for SourceIndexing.
		/// </summary>
		// Token: 0x0600FE8B RID: 65163 RVA: 0x001626B0 File Offset: 0x001608B0
		public virtual bool GetUseSourceTableTree()
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_GetUseSourceTableTree_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FE8C RID: 65164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE8D RID: 65165 RVA: 0x001626D8 File Offset: 0x001608D8
		public override int IsA(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x0600FE8E RID: 65166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph3DMapper_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE8F RID: 65167 RVA: 0x001626F8 File Offset: 0x001608F8
		public new static int IsTypeOf(string type)
		{
			return vtkGlyph3DMapper.vtkGlyph3DMapper_IsTypeOf_32(type);
		}

		// Token: 0x0600FE90 RID: 65168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_MaskingOff_33(HandleRef pThis);

		/// <summary>
		/// Tells the mapper to skip glyphing input points that haves false values
		/// in the mask array. If there is no mask array (id access mode is set
		/// and there is no such id, or array name access mode is set and
		/// the there is no such name), masking is silently ignored.
		/// A mask array is a vtkBitArray with only one component.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FE91 RID: 65169 RVA: 0x00162712 File Offset: 0x00160912
		public virtual void MaskingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_MaskingOff_33(base.GetCppThis());
		}

		// Token: 0x0600FE92 RID: 65170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_MaskingOn_34(HandleRef pThis);

		/// <summary>
		/// Tells the mapper to skip glyphing input points that haves false values
		/// in the mask array. If there is no mask array (id access mode is set
		/// and there is no such id, or array name access mode is set and
		/// the there is no such name), masking is silently ignored.
		/// A mask array is a vtkBitArray with only one component.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FE93 RID: 65171 RVA: 0x00162721 File Offset: 0x00160921
		public virtual void MaskingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_MaskingOn_34(base.GetCppThis());
		}

		// Token: 0x0600FE94 RID: 65172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE95 RID: 65173 RVA: 0x00162730 File Offset: 0x00160930
		public new vtkGlyph3DMapper NewInstance()
		{
			vtkGlyph3DMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FE96 RID: 65174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_OrientOff_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry.
		/// When turned on, the orientation array specified
		/// using SetOrientationArray() will be used.
		/// </summary>
		// Token: 0x0600FE97 RID: 65175 RVA: 0x0016278A File Offset: 0x0016098A
		public virtual void OrientOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_OrientOff_37(base.GetCppThis());
		}

		// Token: 0x0600FE98 RID: 65176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_OrientOn_38(HandleRef pThis);

		/// <summary>
		/// Turn on/off orienting of input geometry.
		/// When turned on, the orientation array specified
		/// using SetOrientationArray() will be used.
		/// </summary>
		// Token: 0x0600FE99 RID: 65177 RVA: 0x00162799 File Offset: 0x00160999
		public virtual void OrientOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_OrientOn_38(base.GetCppThis());
		}

		// Token: 0x0600FE9A RID: 65178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_Render_39(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// All the work is done is derived classes.
		/// </summary>
		// Token: 0x0600FE9B RID: 65179 RVA: 0x001627A8 File Offset: 0x001609A8
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_Render_39(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600FE9C RID: 65180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph3DMapper_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FE9D RID: 65181 RVA: 0x001627EC File Offset: 0x001609EC
		public new static vtkGlyph3DMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph3DMapper vtkGlyph3DMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph3DMapper.vtkGlyph3DMapper_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph3DMapper = (vtkGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph3DMapper.Register(null);
				}
			}
			return vtkGlyph3DMapper;
		}

		// Token: 0x0600FE9E RID: 65182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_ScalingOff_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
		/// controls the scale applied. To scale with some data array, ScaleMode should
		/// be set accordingly.
		/// </summary>
		// Token: 0x0600FE9F RID: 65183 RVA: 0x0016286B File Offset: 0x00160A6B
		public virtual void ScalingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ScalingOff_41(base.GetCppThis());
		}

		// Token: 0x0600FEA0 RID: 65184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_ScalingOn_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
		/// controls the scale applied. To scale with some data array, ScaleMode should
		/// be set accordingly.
		/// </summary>
		// Token: 0x0600FEA1 RID: 65185 RVA: 0x0016287A File Offset: 0x00160A7A
		public virtual void ScalingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_ScalingOn_42(base.GetCppThis());
		}

		// Token: 0x0600FEA2 RID: 65186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetBlockAttributes_43(HandleRef pThis, HandleRef attr);

		/// <summary>
		/// When the input data object (not the source) is composite data,
		/// it is possible to control visibility and pickability on a per-block
		/// basis by passing the mapper a vtkCompositeDataDisplayAttributes instance.
		/// The color and opacity in the display-attributes instance are ignored
		/// for now. By default, the mapper does not own a display-attributes
		/// instance. The value of BlockAttributes has no effect when the input
		/// is a poly-data object.
		/// </summary>
		// Token: 0x0600FEA3 RID: 65187 RVA: 0x0016288C File Offset: 0x00160A8C
		public virtual void SetBlockAttributes(vtkCompositeDataDisplayAttributes attr)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetBlockAttributes_43(base.GetCppThis(), (attr == null) ? default(HandleRef) : attr.GetCppThis());
		}

		// Token: 0x0600FEA4 RID: 65188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetClamping_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off clamping of data values to scale with to the specified range.
		/// </summary>
		// Token: 0x0600FEA5 RID: 65189 RVA: 0x001628BB File Offset: 0x00160ABB
		public virtual void SetClamping(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetClamping_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEA6 RID: 65190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetCullingAndLOD_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable or disable frustum culling and LOD of the instances.
		/// When enabled, an OpenGL driver supporting GL_ARB_gpu_shader5 extension is mandatory.
		/// </summary>
		// Token: 0x0600FEA7 RID: 65191 RVA: 0x001628D3 File Offset: 0x00160AD3
		public virtual void SetCullingAndLOD(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetCullingAndLOD_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEA8 RID: 65192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetInputData_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x0600FEA9 RID: 65193 RVA: 0x001628EC File Offset: 0x00160AEC
		public void SetInputData(vtkDataObject arg0)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetInputData_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600FEAA RID: 65194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetLODColoring_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable LOD coloring. It can be useful to configure properly the LODs.
		/// Each LOD have a unique color, based on its index.
		/// </summary>
		// Token: 0x0600FEAB RID: 65195 RVA: 0x0016291B File Offset: 0x00160B1B
		public virtual void SetLODColoring(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetLODColoring_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEAC RID: 65196
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetLODDistanceAndTargetReduction_48(HandleRef pThis, long arg0, float arg1, float arg2);

		/// <summary>
		/// Configure LODs. Culling must be enabled.
		/// distance have to be a positive value, it is the distance to the camera scaled by
		/// the instanced geometry bounding box.
		/// targetReduction have to be between 0 and 1, 0 disable decimation, 1 draw a point.
		/// This method is intended to be reimplemented in inherited classes, current implementation
		/// does nothing.
		///
		/// @sa vtkDecimatePro::SetTargetReduction
		/// </summary>
		// Token: 0x0600FEAD RID: 65197 RVA: 0x00162933 File Offset: 0x00160B33
		public virtual void SetLODDistanceAndTargetReduction(long arg0, float arg1, float arg2)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetLODDistanceAndTargetReduction_48(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600FEAE RID: 65198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetMaskArray_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string maskarrayname);

		/// <summary>
		/// Set the name of the point array to use as a mask for generating the glyphs.
		/// This is a convenience method. The same effect can be achieved by using
		/// SetInputArrayToProcess(vtkGlyph3DMapper::MASK, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, maskarrayname)
		/// </summary>
		// Token: 0x0600FEAF RID: 65199 RVA: 0x00162945 File Offset: 0x00160B45
		public void SetMaskArray(string maskarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMaskArray_49(base.GetCppThis(), maskarrayname);
		}

		// Token: 0x0600FEB0 RID: 65200
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetMaskArray_50(HandleRef pThis, int fieldAttributeType);

		/// <summary>
		/// Set the point attribute to use as a mask for generating the glyphs.
		/// \c fieldAttributeType is one of the following:
		/// \li vtkDataSetAttributes::SCALARS
		/// \li vtkDataSetAttributes::VECTORS
		/// \li vtkDataSetAttributes::NORMALS
		/// \li vtkDataSetAttributes::TCOORDS
		/// \li vtkDataSetAttributes::TENSORS
		/// This is a convenience method. The same effect can be achieved by using
		/// SetInputArrayToProcess(vtkGlyph3DMapper::MASK, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType)
		/// </summary>
		// Token: 0x0600FEB1 RID: 65201 RVA: 0x00162955 File Offset: 0x00160B55
		public void SetMaskArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMaskArray_50(base.GetCppThis(), fieldAttributeType);
		}

		// Token: 0x0600FEB2 RID: 65202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetMasking_51(HandleRef pThis, byte _arg);

		/// <summary>
		/// Tells the mapper to skip glyphing input points that haves false values
		/// in the mask array. If there is no mask array (id access mode is set
		/// and there is no such id, or array name access mode is set and
		/// the there is no such name), masking is silently ignored.
		/// A mask array is a vtkBitArray with only one component.
		/// Initial value is false.
		/// </summary>
		// Token: 0x0600FEB3 RID: 65203 RVA: 0x00162965 File Offset: 0x00160B65
		public virtual void SetMasking(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetMasking_51(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEB4 RID: 65204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetNumberOfLOD_52(HandleRef pThis, long arg0);

		/// <summary>
		/// Set the number of LOD.
		/// This method is intended to be reimplemented in inherited classes, current implementation
		/// does nothing.
		/// </summary>
		// Token: 0x0600FEB5 RID: 65205 RVA: 0x0016297D File Offset: 0x00160B7D
		public virtual void SetNumberOfLOD(long arg0)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetNumberOfLOD_52(base.GetCppThis(), arg0);
		}

		// Token: 0x0600FEB6 RID: 65206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrient_53(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off orienting of input geometry.
		/// When turned on, the orientation array specified
		/// using SetOrientationArray() will be used.
		/// </summary>
		// Token: 0x0600FEB7 RID: 65207 RVA: 0x0016298D File Offset: 0x00160B8D
		public virtual void SetOrient(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrient_53(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEB8 RID: 65208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationArray_54(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string orientationarrayname);

		/// <summary>
		/// Tells the mapper to use an orientation array if Orient is true.
		/// An orientation array is a vtkDataArray with 3 components. The first
		/// component is the angle of rotation along the X axis. The second
		/// component is the angle of rotation along the Y axis. The third
		/// component is the angle of rotation along the Z axis. Orientation is
		/// specified in X,Y,Z order but the rotations are performed in Z,X an Y.
		/// This definition is compliant with SetOrientation method on vtkProp3D.
		/// By using vector or normal there is a degree of freedom or rotation
		/// left (underconstrained). With the orientation array, there is no degree of
		/// freedom left.
		/// This is convenience method. The same effect can be achieved by using
		/// SetInputArrayToProcess(vtkGlyph3DMapper::ORIENTATION, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, orientationarrayname);
		/// </summary>
		// Token: 0x0600FEB9 RID: 65209 RVA: 0x001629A5 File Offset: 0x00160BA5
		public void SetOrientationArray(string orientationarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationArray_54(base.GetCppThis(), orientationarrayname);
		}

		// Token: 0x0600FEBA RID: 65210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationArray_55(HandleRef pThis, int fieldAttributeType);

		/// <summary>
		/// Tells the mapper to use an orientation array if Orient is true.
		/// An orientation array is a vtkDataArray with 3 components. The first
		/// component is the angle of rotation along the X axis. The second
		/// component is the angle of rotation along the Y axis. The third
		/// component is the angle of rotation along the Z axis. Orientation is
		/// specified in X,Y,Z order but the rotations are performed in Z,X an Y.
		/// This definition is compliant with SetOrientation method on vtkProp3D.
		/// By using vector or normal there is a degree of freedom or rotation
		/// left (underconstrained). With the orientation array, there is no degree of
		/// freedom left.
		/// \c fieldAttributeType is one of the following:
		/// \li vtkDataSetAttributes::SCALARS
		/// \li vtkDataSetAttributes::VECTORS
		/// \li vtkDataSetAttributes::NORMALS
		/// \li vtkDataSetAttributes::TCOORDS
		/// \li vtkDataSetAttributes::TENSORS
		/// This is convenience method. The same effect can be achieved by using
		/// SetInputArrayToProcess(vtkGlyph3DMapper::ORIENTATION, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType);
		/// </summary>
		// Token: 0x0600FEBB RID: 65211 RVA: 0x001629B5 File Offset: 0x00160BB5
		public void SetOrientationArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationArray_55(base.GetCppThis(), fieldAttributeType);
		}

		// Token: 0x0600FEBC RID: 65212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationMode_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FEBD RID: 65213 RVA: 0x001629C5 File Offset: 0x00160BC5
		public virtual void SetOrientationMode(int _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationMode_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FEBE RID: 65214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationModeToDirection_57(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FEBF RID: 65215 RVA: 0x001629D5 File Offset: 0x00160BD5
		public void SetOrientationModeToDirection()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationModeToDirection_57(base.GetCppThis());
		}

		// Token: 0x0600FEC0 RID: 65216
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationModeToQuaternion_58(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FEC1 RID: 65217 RVA: 0x001629E4 File Offset: 0x00160BE4
		public void SetOrientationModeToQuaternion()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationModeToQuaternion_58(base.GetCppThis());
		}

		// Token: 0x0600FEC2 RID: 65218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetOrientationModeToRotation_59(HandleRef pThis);

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x0600FEC3 RID: 65219 RVA: 0x001629F3 File Offset: 0x00160BF3
		public void SetOrientationModeToRotation()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetOrientationModeToRotation_59(base.GetCppThis());
		}

		// Token: 0x0600FEC4 RID: 65220
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetRange_60(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600FEC5 RID: 65221 RVA: 0x00162A02 File Offset: 0x00160C02
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetRange_60(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600FEC6 RID: 65222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetRange_61(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify range to map scalar values into.
		/// </summary>
		// Token: 0x0600FEC7 RID: 65223 RVA: 0x00162A13 File Offset: 0x00160C13
		public void SetRange(IntPtr _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetRange_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FEC8 RID: 65224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleArray_62(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string scalarsarrayname);

		/// <summary>
		/// Convenience method to set the array to scale with. This is same as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SCALE, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, scalarsarrayname).
		/// </summary>
		// Token: 0x0600FEC9 RID: 65225 RVA: 0x00162A23 File Offset: 0x00160C23
		public void SetScaleArray(string scalarsarrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleArray_62(base.GetCppThis(), scalarsarrayname);
		}

		// Token: 0x0600FECA RID: 65226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleArray_63(HandleRef pThis, int fieldAttributeType);

		/// <summary>
		/// Convenience method to set the array to scale with. This is same as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SCALE, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
		/// </summary>
		// Token: 0x0600FECB RID: 65227 RVA: 0x00162A33 File Offset: 0x00160C33
		public void SetScaleArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleArray_63(base.GetCppThis(), fieldAttributeType);
		}

		// Token: 0x0600FECC RID: 65228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleFactor_64(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FECD RID: 65229 RVA: 0x00162A43 File Offset: 0x00160C43
		public virtual void SetScaleFactor(double _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleFactor_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FECE RID: 65230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleMode_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Either scale by individual components (SCALE_BY_COMPONENTS) or magnitude
		/// (SCALE_BY_MAGNITUDE) of the chosen array to SCALE with or disable scaling
		/// using data array all together (NO_DATA_SCALING). Default is
		/// NO_DATA_SCALING.
		/// </summary>
		// Token: 0x0600FECF RID: 65231 RVA: 0x00162A53 File Offset: 0x00160C53
		public virtual void SetScaleMode(int _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleMode_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FED0 RID: 65232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToNoDataScaling_66(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FED1 RID: 65233 RVA: 0x00162A63 File Offset: 0x00160C63
		public void SetScaleModeToNoDataScaling()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToNoDataScaling_66(base.GetCppThis());
		}

		// Token: 0x0600FED2 RID: 65234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_67(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FED3 RID: 65235 RVA: 0x00162A72 File Offset: 0x00160C72
		public void SetScaleModeToScaleByMagnitude()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToScaleByMagnitude_67(base.GetCppThis());
		}

		// Token: 0x0600FED4 RID: 65236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_68(HandleRef pThis);

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x0600FED5 RID: 65237 RVA: 0x00162A81 File Offset: 0x00160C81
		public void SetScaleModeToScaleByVectorComponents()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaleModeToScaleByVectorComponents_68(base.GetCppThis());
		}

		// Token: 0x0600FED6 RID: 65238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetScaling_69(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off scaling of source geometry. When turned on, ScaleFactor
		/// controls the scale applied. To scale with some data array, ScaleMode should
		/// be set accordingly.
		/// </summary>
		// Token: 0x0600FED7 RID: 65239 RVA: 0x00162A90 File Offset: 0x00160C90
		public virtual void SetScaling(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetScaling_69(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FED8 RID: 65240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSelectionColorId_70(HandleRef pThis, uint _arg);

		/// <summary>
		/// For selection by color id mode (not for end-user, called by
		/// vtkGlyphSelectionRenderMode). 0 is reserved for miss. it has to
		/// start at 1. Initial value is 1.
		/// </summary>
		// Token: 0x0600FED9 RID: 65241 RVA: 0x00162AA8 File Offset: 0x00160CA8
		public virtual void SetSelectionColorId(uint _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSelectionColorId_70(base.GetCppThis(), _arg);
		}

		// Token: 0x0600FEDA RID: 65242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSelectionIdArray_71(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string selectionIdArrayName);

		/// <summary>
		/// Convenience method to set the array used for selection IDs. This is same
		/// as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SELECTIONID, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, selectionidarrayname).
		///
		/// If no selection id array is specified, the index of the glyph point is
		/// used.
		/// </summary>
		// Token: 0x0600FEDB RID: 65243 RVA: 0x00162AB8 File Offset: 0x00160CB8
		public void SetSelectionIdArray(string selectionIdArrayName)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSelectionIdArray_71(base.GetCppThis(), selectionIdArrayName);
		}

		// Token: 0x0600FEDC RID: 65244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSelectionIdArray_72(HandleRef pThis, int fieldAttributeType);

		/// <summary>
		/// Convenience method to set the array used for selection IDs. This is same
		/// as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SELECTIONID, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
		///
		/// If no selection id array is specified, the index of the glyph point is
		/// used.
		/// </summary>
		// Token: 0x0600FEDD RID: 65245 RVA: 0x00162AC8 File Offset: 0x00160CC8
		public void SetSelectionIdArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSelectionIdArray_72(base.GetCppThis(), fieldAttributeType);
		}

		// Token: 0x0600FEDE RID: 65246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceConnection_73(HandleRef pThis, int idx, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x0600FEDF RID: 65247 RVA: 0x00162AD8 File Offset: 0x00160CD8
		public void SetSourceConnection(int idx, vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceConnection_73(base.GetCppThis(), idx, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600FEE0 RID: 65248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceConnection_74(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify a source object at a specified table location. New style.
		/// Source connection is stored in port 1. This method is equivalent
		/// to SetInputConnection(1, id, outputPort).
		/// </summary>
		// Token: 0x0600FEE1 RID: 65249 RVA: 0x00162B08 File Offset: 0x00160D08
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceConnection_74(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600FEE2 RID: 65250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceData_75(HandleRef pThis, int idx, HandleRef pd);

		/// <summary>
		/// Specify a source object at a specified table location.
		/// </summary>
		// Token: 0x0600FEE3 RID: 65251 RVA: 0x00162B38 File Offset: 0x00160D38
		public void SetSourceData(int idx, vtkPolyData pd)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceData_75(base.GetCppThis(), idx, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600FEE4 RID: 65252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceData_76(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Set the source to use for he glyph.
		/// Note that this method does not connect the pipeline. The algorithm will
		/// work on the input data as it is without updating the producer of the data.
		/// See SetSourceConnection for connecting the pipeline.
		/// </summary>
		// Token: 0x0600FEE5 RID: 65253 RVA: 0x00162B68 File Offset: 0x00160D68
		public void SetSourceData(vtkPolyData pd)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceData_76(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600FEE6 RID: 65254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_77(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayname);

		/// <summary>
		/// Convenience method to set the array to use as index within the sources.
		/// This is same as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SOURCE_INDEX, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, arrayname).
		/// </summary>
		// Token: 0x0600FEE7 RID: 65255 RVA: 0x00162B97 File Offset: 0x00160D97
		public void SetSourceIndexArray(string arrayname)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexArray_77(base.GetCppThis(), arrayname);
		}

		// Token: 0x0600FEE8 RID: 65256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexArray_78(HandleRef pThis, int fieldAttributeType);

		/// <summary>
		/// Convenience method to set the array to use as index within the sources.
		/// This is same as calling
		/// SetInputArrayToProcess(vtkGlyph3DMapper::SOURCE_INDEX, 0, 0,
		/// vtkDataObject::FIELD_ASSOCIATION_POINTS, fieldAttributeType).
		/// </summary>
		// Token: 0x0600FEE9 RID: 65257 RVA: 0x00162BA7 File Offset: 0x00160DA7
		public void SetSourceIndexArray(int fieldAttributeType)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexArray_78(base.GetCppThis(), fieldAttributeType);
		}

		// Token: 0x0600FEEA RID: 65258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceIndexing_79(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable indexing into table of the glyph sources. When disabled,
		/// only the 1st source input will be used to generate the glyph. Otherwise the
		/// source index array will be used to select the glyph source. The source
		/// index array can be specified using SetSourceIndexArray().
		/// </summary>
		// Token: 0x0600FEEB RID: 65259 RVA: 0x00162BB7 File Offset: 0x00160DB7
		public virtual void SetSourceIndexing(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceIndexing_79(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEEC RID: 65260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetSourceTableTree_80(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Specify a data object tree that will be used for the source table. Requires
		/// UseSourceTableTree to be true. The top-level nodes of the tree are mapped
		/// to the source data inputs.
		///
		/// Must only contain vtkPolyData instances on the OpenGL backend. May contain
		/// vtkCompositeDataSets with vtkPolyData leaves on OpenGL2.
		/// </summary>
		// Token: 0x0600FEED RID: 65261 RVA: 0x00162BD0 File Offset: 0x00160DD0
		public void SetSourceTableTree(vtkDataObjectTree tree)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetSourceTableTree_80(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x0600FEEE RID: 65262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetUseSelectionIds_81(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off custom selection ids. If enabled, the id values set with
		/// SetSelectionIdArray are returned from pick events.
		/// </summary>
		// Token: 0x0600FEEF RID: 65263 RVA: 0x00162BFF File Offset: 0x00160DFF
		public virtual void SetUseSelectionIds(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetUseSelectionIds_81(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEF0 RID: 65264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SetUseSourceTableTree_82(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
		/// the top-level members of the tree will be mapped to the glyph source table
		/// used for SourceIndexing.
		/// </summary>
		// Token: 0x0600FEF1 RID: 65265 RVA: 0x00162C17 File Offset: 0x00160E17
		public virtual void SetUseSourceTableTree(bool _arg)
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SetUseSourceTableTree_82(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FEF2 RID: 65266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SourceIndexingOff_83(HandleRef pThis);

		/// <summary>
		/// Enable/disable indexing into table of the glyph sources. When disabled,
		/// only the 1st source input will be used to generate the glyph. Otherwise the
		/// source index array will be used to select the glyph source. The source
		/// index array can be specified using SetSourceIndexArray().
		/// </summary>
		// Token: 0x0600FEF3 RID: 65267 RVA: 0x00162C2F File Offset: 0x00160E2F
		public virtual void SourceIndexingOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SourceIndexingOff_83(base.GetCppThis());
		}

		// Token: 0x0600FEF4 RID: 65268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_SourceIndexingOn_84(HandleRef pThis);

		/// <summary>
		/// Enable/disable indexing into table of the glyph sources. When disabled,
		/// only the 1st source input will be used to generate the glyph. Otherwise the
		/// source index array will be used to select the glyph source. The source
		/// index array can be specified using SetSourceIndexArray().
		/// </summary>
		// Token: 0x0600FEF5 RID: 65269 RVA: 0x00162C3E File Offset: 0x00160E3E
		public virtual void SourceIndexingOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_SourceIndexingOn_84(base.GetCppThis());
		}

		// Token: 0x0600FEF6 RID: 65270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_UseSelectionIdsOff_85(HandleRef pThis);

		/// <summary>
		/// Turn on/off custom selection ids. If enabled, the id values set with
		/// SetSelectionIdArray are returned from pick events.
		/// </summary>
		// Token: 0x0600FEF7 RID: 65271 RVA: 0x00162C4D File Offset: 0x00160E4D
		public virtual void UseSelectionIdsOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_UseSelectionIdsOff_85(base.GetCppThis());
		}

		// Token: 0x0600FEF8 RID: 65272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_UseSelectionIdsOn_86(HandleRef pThis);

		/// <summary>
		/// Turn on/off custom selection ids. If enabled, the id values set with
		/// SetSelectionIdArray are returned from pick events.
		/// </summary>
		// Token: 0x0600FEF9 RID: 65273 RVA: 0x00162C5C File Offset: 0x00160E5C
		public virtual void UseSelectionIdsOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_UseSelectionIdsOn_86(base.GetCppThis());
		}

		// Token: 0x0600FEFA RID: 65274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_UseSourceTableTreeOff_87(HandleRef pThis);

		/// <summary>
		/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
		/// the top-level members of the tree will be mapped to the glyph source table
		/// used for SourceIndexing.
		/// </summary>
		// Token: 0x0600FEFB RID: 65275 RVA: 0x00162C6B File Offset: 0x00160E6B
		public virtual void UseSourceTableTreeOff()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_UseSourceTableTreeOff_87(base.GetCppThis());
		}

		// Token: 0x0600FEFC RID: 65276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGlyph3DMapper_UseSourceTableTreeOn_88(HandleRef pThis);

		/// <summary>
		/// If true, and the glyph source dataset is a subclass of vtkDataObjectTree,
		/// the top-level members of the tree will be mapped to the glyph source table
		/// used for SourceIndexing.
		/// </summary>
		// Token: 0x0600FEFD RID: 65277 RVA: 0x00162C7A File Offset: 0x00160E7A
		public virtual void UseSourceTableTreeOn()
		{
			vtkGlyph3DMapper.vtkGlyph3DMapper_UseSourceTableTreeOn_88(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001286 RID: 4742
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph3DMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001287 RID: 4743
		public new static readonly string MRClassNameKey = "class vtkGlyph3DMapper";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020005AB RID: 1451
		public enum ArrayIndexes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001289 RID: 4745
			MASK = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400128A RID: 4746
			ORIENTATION,
			/// <summary>enum member</summary>
			// Token: 0x0400128B RID: 4747
			SCALE = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400128C RID: 4748
			SELECTIONID = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400128D RID: 4749
			SOURCE_INDEX = 1
		}

		/// <summary>
		/// Orientation mode indicates if the OrientationArray provides the direction
		/// vector for the orientation or the rotations around each axes. Default is
		/// DIRECTION
		/// </summary>
		// Token: 0x020005AC RID: 1452
		public enum OrientationModes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400128F RID: 4751
			DIRECTION,
			/// <summary>enum member</summary>
			// Token: 0x04001290 RID: 4752
			QUATERNION = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001291 RID: 4753
			ROTATION = 1
		}

		/// <summary>
		/// Specify scale factor to scale object by. This is used only when Scaling is
		/// On.
		/// </summary>
		// Token: 0x020005AD RID: 1453
		public enum ScaleModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001293 RID: 4755
			NO_DATA_SCALING,
			/// <summary>enum member</summary>
			// Token: 0x04001294 RID: 4756
			SCALE_BY_COMPONENTS = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001295 RID: 4757
			SCALE_BY_MAGNITUDE = 1
		}
	}
}
