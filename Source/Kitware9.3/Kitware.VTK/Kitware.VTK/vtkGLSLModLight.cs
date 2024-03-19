using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModLight
	/// </summary>
	/// <remarks>
	///    Implement light kit support in the OpenGL renderer for vtkCellGrid.
	/// </remarks>
	// Token: 0x02000595 RID: 1429
	public class vtkGLSLModLight : vtkGLSLModifierBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FBC2 RID: 64450 RVA: 0x0015E5DF File Offset: 0x0015C7DF
		static vtkGLSLModLight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModLight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBC3 RID: 64451 RVA: 0x0015E607 File Offset: 0x0015C807
		public vtkGLSLModLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FBC4 RID: 64452
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBC5 RID: 64453 RVA: 0x0015E618 File Offset: 0x0015C818
		public new static vtkGLSLModLight New()
		{
			vtkGLSLModLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModLight.vtkGLSLModLight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBC6 RID: 64454 RVA: 0x0015E66C File Offset: 0x0015C86C
		public vtkGLSLModLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLSLModLight.vtkGLSLModLight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBC7 RID: 64455 RVA: 0x0015E6B0 File Offset: 0x0015C8B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FBC8 RID: 64456
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModLight_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBC9 RID: 64457 RVA: 0x0015E6BC File Offset: 0x0015C8BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLSLModLight.vtkGLSLModLight_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FBCA RID: 64458
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModLight_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBCB RID: 64459 RVA: 0x0015E6DC File Offset: 0x0015C8DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLSLModLight.vtkGLSLModLight_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FBCC RID: 64460
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModLight_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBCD RID: 64461 RVA: 0x0015E6F8 File Offset: 0x0015C8F8
		public override int IsA(string type)
		{
			return vtkGLSLModLight.vtkGLSLModLight_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FBCE RID: 64462
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModLight_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBCF RID: 64463 RVA: 0x0015E718 File Offset: 0x0015C918
		public new static int IsTypeOf(string type)
		{
			return vtkGLSLModLight.vtkGLSLModLight_IsTypeOf_04(type);
		}

		// Token: 0x0600FBD0 RID: 64464
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModLight_IsUpToDate_05(HandleRef pThis, HandleRef renderer, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBD1 RID: 64465 RVA: 0x0015E734 File Offset: 0x0015C934
		public override bool IsUpToDate(vtkOpenGLRenderer renderer, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModLight.vtkGLSLModLight_IsUpToDate_05(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FBD2 RID: 64466
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModLight_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBD3 RID: 64467 RVA: 0x0015E79C File Offset: 0x0015C99C
		public new vtkGLSLModLight NewInstance()
		{
			vtkGLSLModLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModLight.vtkGLSLModLight_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FBD4 RID: 64468
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModLight_ReplaceShaderValues_08(HandleRef pThis, HandleRef renderer, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBD5 RID: 64469 RVA: 0x0015E7F8 File Offset: 0x0015C9F8
		public override bool ReplaceShaderValues(vtkOpenGLRenderer renderer, string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModLight.vtkGLSLModLight_ReplaceShaderValues_08(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FBD6 RID: 64470
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModLight_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBD7 RID: 64471 RVA: 0x0015E868 File Offset: 0x0015CA68
		public new static vtkGLSLModLight SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLModLight vtkGLSLModLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModLight.vtkGLSLModLight_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModLight = (vtkGLSLModLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModLight.Register(null);
				}
			}
			return vtkGLSLModLight;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001252 RID: 4690
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModLight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001253 RID: 4691
		public new static readonly string MRClassNameKey = "class vtkGLSLModLight";
	}
}
