using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLProperty
	/// </summary>
	/// <remarks>
	///    OpenGL property
	///
	/// vtkOpenGLProperty is a concrete implementation of the abstract class
	/// vtkProperty. vtkOpenGLProperty interfaces to the OpenGL rendering library.
	/// </remarks>
	// Token: 0x020005C2 RID: 1474
	public class vtkOpenGLProperty : vtkProperty
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601021D RID: 66077 RVA: 0x00167773 File Offset: 0x00165973
		static vtkOpenGLProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601021E RID: 66078 RVA: 0x0016779B File Offset: 0x0016599B
		public vtkOpenGLProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601021F RID: 66079
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010220 RID: 66080 RVA: 0x001677AC File Offset: 0x001659AC
		public new static vtkOpenGLProperty New()
		{
			vtkOpenGLProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010221 RID: 66081 RVA: 0x00167800 File Offset: 0x00165A00
		public vtkOpenGLProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLProperty.vtkOpenGLProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010222 RID: 66082 RVA: 0x00167844 File Offset: 0x00165A44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010223 RID: 66083
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProperty_BackfaceRender_01(HandleRef pThis, HandleRef a, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010224 RID: 66084 RVA: 0x00167850 File Offset: 0x00165A50
		public override void BackfaceRender(vtkActor a, vtkRenderer ren)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_BackfaceRender_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010225 RID: 66085
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLProperty_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010226 RID: 66086 RVA: 0x00167894 File Offset: 0x00165A94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06010227 RID: 66087
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLProperty_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010228 RID: 66088 RVA: 0x001678B4 File Offset: 0x00165AB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06010229 RID: 66089
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLProperty_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601022A RID: 66090 RVA: 0x001678D0 File Offset: 0x00165AD0
		public override int IsA(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601022B RID: 66091
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLProperty_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601022C RID: 66092 RVA: 0x001678F0 File Offset: 0x00165AF0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLProperty.vtkOpenGLProperty_IsTypeOf_05(type);
		}

		// Token: 0x0601022D RID: 66093
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProperty_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601022E RID: 66094 RVA: 0x0016790C File Offset: 0x00165B0C
		public new vtkOpenGLProperty NewInstance()
		{
			vtkOpenGLProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601022F RID: 66095
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProperty_PostRender_08(HandleRef pThis, HandleRef a, HandleRef r);

		/// <summary>
		/// This method is called after the actor has been rendered.
		/// Don't call this directly. This method cleans up
		/// any shaders allocated.
		/// </summary>
		// Token: 0x06010230 RID: 66096 RVA: 0x00167968 File Offset: 0x00165B68
		public override void PostRender(vtkActor a, vtkRenderer r)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_PostRender_08(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06010231 RID: 66097
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProperty_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any graphics resources that are being consumed by this
		/// property. The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06010232 RID: 66098 RVA: 0x001679AC File Offset: 0x00165BAC
		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_ReleaseGraphicsResources_09(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06010233 RID: 66099
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLProperty_Render_10(HandleRef pThis, HandleRef a, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010234 RID: 66100 RVA: 0x001679DC File Offset: 0x00165BDC
		public override void Render(vtkActor a, vtkRenderer ren)
		{
			vtkOpenGLProperty.vtkOpenGLProperty_Render_10(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010235 RID: 66101
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLProperty_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010236 RID: 66102 RVA: 0x00167A20 File Offset: 0x00165C20
		public new static vtkOpenGLProperty SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLProperty vtkOpenGLProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLProperty.vtkOpenGLProperty_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLProperty = (vtkOpenGLProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLProperty.Register(null);
				}
			}
			return vtkOpenGLProperty;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C6 RID: 4806
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012C7 RID: 4807
		public new static readonly string MRClassNameKey = "class vtkOpenGLProperty";
	}
}
