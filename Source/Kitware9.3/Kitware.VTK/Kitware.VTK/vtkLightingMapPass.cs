using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightingMapPass
	/// </summary>
	/// <remarks>
	///    TO DO
	///
	/// Renders lighting information directly instead of final shaded colors.
	/// The information keys allow the selection of either normal rendering or
	/// luminance. For normals, the (nx, ny, nz) tuple are rendered directly into
	/// the (r,g,b) fragment. For luminance, the diffuse and specular intensities are
	/// rendered into the red and green channels, respectively. The blue channel is
	/// zero. For both luminances and normals, the alpha channel is set to 1.0 if
	/// present.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderPass vtkDefaultPass
	/// </seealso>
	// Token: 0x02000599 RID: 1433
	public class vtkLightingMapPass : vtkDefaultPass
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FC07 RID: 64519 RVA: 0x0015EED7 File Offset: 0x0015D0D7
		static vtkLightingMapPass()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightingMapPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightingMapPass"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC08 RID: 64520 RVA: 0x0015EEFF File Offset: 0x0015D0FF
		public vtkLightingMapPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FC09 RID: 64521
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightingMapPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC0A RID: 64522 RVA: 0x0015EF10 File Offset: 0x0015D110
		public new static vtkLightingMapPass New()
		{
			vtkLightingMapPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightingMapPass.vtkLightingMapPass_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC0B RID: 64523 RVA: 0x0015EF64 File Offset: 0x0015D164
		public vtkLightingMapPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightingMapPass.vtkLightingMapPass_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FC0C RID: 64524 RVA: 0x0015EFA8 File Offset: 0x0015D1A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FC0D RID: 64525
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightingMapPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC0E RID: 64526 RVA: 0x0015EFB4 File Offset: 0x0015D1B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightingMapPass.vtkLightingMapPass_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FC0F RID: 64527
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightingMapPass_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC10 RID: 64528 RVA: 0x0015EFD4 File Offset: 0x0015D1D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightingMapPass.vtkLightingMapPass_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FC11 RID: 64529
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkLightingMapPass.RenderMode vtkLightingMapPass_GetRenderType_03(HandleRef pThis);

		/// <summary>
		/// Set the type of lighting render to perform
		/// </summary>
		// Token: 0x0600FC12 RID: 64530 RVA: 0x0015EFF0 File Offset: 0x0015D1F0
		public virtual vtkLightingMapPass.RenderMode GetRenderType()
		{
			return vtkLightingMapPass.vtkLightingMapPass_GetRenderType_03(base.GetCppThis());
		}

		// Token: 0x0600FC13 RID: 64531
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightingMapPass_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC14 RID: 64532 RVA: 0x0015F010 File Offset: 0x0015D210
		public override int IsA(string type)
		{
			return vtkLightingMapPass.vtkLightingMapPass_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FC15 RID: 64533
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightingMapPass_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC16 RID: 64534 RVA: 0x0015F030 File Offset: 0x0015D230
		public new static int IsTypeOf(string type)
		{
			return vtkLightingMapPass.vtkLightingMapPass_IsTypeOf_05(type);
		}

		// Token: 0x0600FC17 RID: 64535
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightingMapPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC18 RID: 64536 RVA: 0x0015F04C File Offset: 0x0015D24C
		public new vtkLightingMapPass NewInstance()
		{
			vtkLightingMapPass result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightingMapPass.vtkLightingMapPass_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FC19 RID: 64537
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightingMapPass_RENDER_LUMINANCE_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If this key exists on the PropertyKeys of a prop, the active scalar array
		/// on the prop will be rendered as its color. This key is mutually exclusive
		/// with the RENDER_LUMINANCE key.
		/// </summary>
		// Token: 0x0600FC1A RID: 64538 RVA: 0x0015F0A8 File Offset: 0x0015D2A8
		public static vtkInformationIntegerKey RENDER_LUMINANCE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightingMapPass.vtkLightingMapPass_RENDER_LUMINANCE_08(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600FC1B RID: 64539
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightingMapPass_RENDER_NORMALS_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// if this key exists on the ProperyKeys of a prop, the active vector array on
		/// the prop will be rendered as its color. This key is mutually exclusive with
		/// the RENDER_LUMINANCE key.
		/// </summary>
		// Token: 0x0600FC1C RID: 64540 RVA: 0x0015F114 File Offset: 0x0015D314
		public static vtkInformationIntegerKey RENDER_NORMALS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightingMapPass.vtkLightingMapPass_RENDER_NORMALS_09(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600FC1D RID: 64541
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightingMapPass_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FC1E RID: 64542 RVA: 0x0015F180 File Offset: 0x0015D380
		public new static vtkLightingMapPass SafeDownCast(vtkObjectBase o)
		{
			vtkLightingMapPass vtkLightingMapPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightingMapPass.vtkLightingMapPass_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightingMapPass = (vtkLightingMapPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightingMapPass.Register(null);
				}
			}
			return vtkLightingMapPass;
		}

		// Token: 0x0600FC1F RID: 64543
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightingMapPass_SetRenderType_11(HandleRef pThis, vtkLightingMapPass.RenderMode _arg);

		/// <summary>
		/// Set the type of lighting render to perform
		/// </summary>
		// Token: 0x0600FC20 RID: 64544 RVA: 0x0015F1FF File Offset: 0x0015D3FF
		public virtual void SetRenderType(vtkLightingMapPass.RenderMode _arg)
		{
			vtkLightingMapPass.vtkLightingMapPass_SetRenderType_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400125A RID: 4698
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightingMapPass";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400125B RID: 4699
		public new static readonly string MRClassNameKey = "class vtkLightingMapPass";

		/// <summary>
		/// Set the type of lighting render to perform
		/// </summary>
		// Token: 0x0200059A RID: 1434
		public enum RenderMode
		{
			/// <summary>enum member</summary>
			// Token: 0x0400125D RID: 4701
			LUMINANCE,
			/// <summary>enum member</summary>
			// Token: 0x0400125E RID: 4702
			NORMALS
		}
	}
}
