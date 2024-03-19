using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeMapper
	/// </summary>
	/// <remarks>
	///    Abstract class for an unstructured grid volume mapper
	///
	///
	/// vtkUnstructuredGridVolumeMapper is the abstract definition of a volume mapper for
	/// unstructured data (vtkUnstructuredGrid). Several basic types of volume mappers
	/// are supported as subclasses.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastMapper
	/// </seealso>
	// Token: 0x020000CD RID: 205
	public abstract class vtkUnstructuredGridVolumeMapper : vtkAbstractVolumeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002BC9 RID: 11209 RVA: 0x00040B9E File Offset: 0x0003ED9E
		static vtkUnstructuredGridVolumeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002BCA RID: 11210 RVA: 0x00040BC6 File Offset: 0x0003EDC6
		public vtkUnstructuredGridVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002BCB RID: 11211 RVA: 0x00040BD4 File Offset: 0x0003EDD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002BCC RID: 11212
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeMapper_GetBlendMode_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BCD RID: 11213 RVA: 0x00040BE0 File Offset: 0x0003EDE0
		public virtual int GetBlendMode()
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetBlendMode_01(base.GetCppThis());
		}

		// Token: 0x06002BCE RID: 11214
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BCF RID: 11215 RVA: 0x00040C00 File Offset: 0x0003EE00
		public vtkUnstructuredGridBase GetInput()
		{
			vtkUnstructuredGridBase vtkUnstructuredGridBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridBase = (vtkUnstructuredGridBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridBase.Register(null);
				}
			}
			return vtkUnstructuredGridBase;
		}

		// Token: 0x06002BD0 RID: 11216
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BD1 RID: 11217 RVA: 0x00040C70 File Offset: 0x0003EE70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06002BD2 RID: 11218
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BD3 RID: 11219 RVA: 0x00040C90 File Offset: 0x0003EE90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06002BD4 RID: 11220
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeMapper_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BD5 RID: 11221 RVA: 0x00040CAC File Offset: 0x0003EEAC
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002BD6 RID: 11222
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BD7 RID: 11223 RVA: 0x00040CCC File Offset: 0x0003EECC
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_IsTypeOf_06(type);
		}

		// Token: 0x06002BD8 RID: 11224
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BD9 RID: 11225 RVA: 0x00040CE8 File Offset: 0x0003EEE8
		public new vtkUnstructuredGridVolumeMapper NewInstance()
		{
			vtkUnstructuredGridVolumeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002BDA RID: 11226
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06002BDB RID: 11227 RVA: 0x00040D44 File Offset: 0x0003EF44
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002BDC RID: 11228
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_Render_09(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Render the volume
		/// </summary>
		// Token: 0x06002BDD RID: 11229 RVA: 0x00040D74 File Offset: 0x0003EF74
		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_Render_09(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x06002BDE RID: 11230
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002BDF RID: 11231 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		public new static vtkUnstructuredGridVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeMapper vtkUnstructuredGridVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeMapper = (vtkUnstructuredGridVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeMapper.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeMapper;
		}

		// Token: 0x06002BE0 RID: 11232
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendMode_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BE1 RID: 11233 RVA: 0x00040E37 File Offset: 0x0003F037
		public virtual void SetBlendMode(int _arg)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendMode_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06002BE2 RID: 11234
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BE3 RID: 11235 RVA: 0x00040E47 File Offset: 0x0003F047
		public void SetBlendModeToComposite()
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendModeToComposite_12(base.GetCppThis());
		}

		// Token: 0x06002BE4 RID: 11236
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BE5 RID: 11237 RVA: 0x00040E56 File Offset: 0x0003F056
		public void SetBlendModeToMaximumIntensity()
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetBlendModeToMaximumIntensity_13(base.GetCppThis());
		}

		// Token: 0x06002BE6 RID: 11238
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetInputData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BE7 RID: 11239 RVA: 0x00040E68 File Offset: 0x0003F068
		public virtual void SetInputData(vtkUnstructuredGridBase arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetInputData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002BE8 RID: 11240
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeMapper_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input data
		/// </summary>
		// Token: 0x06002BE9 RID: 11241 RVA: 0x00040E98 File Offset: 0x0003F098
		public virtual void SetInputData(vtkDataSet arg0)
		{
			vtkUnstructuredGridVolumeMapper.vtkUnstructuredGridVolumeMapper_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400058C RID: 1420
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400058D RID: 1421
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeMapper";

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x020000CE RID: 206
		public enum COMPOSITE_BLEND_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400058F RID: 1423
			COMPOSITE_BLEND,
			/// <summary>enum member</summary>
			// Token: 0x04000590 RID: 1424
			MAXIMUM_INTENSITY_BLEND
		}
	}
}
