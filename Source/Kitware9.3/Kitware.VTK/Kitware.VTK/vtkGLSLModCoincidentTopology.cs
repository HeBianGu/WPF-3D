using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModCoincidentTopology
	/// </summary>
	/// <remarks>
	///    Handle coincident topology
	/// </remarks>
	// Token: 0x02000594 RID: 1428
	public class vtkGLSLModCoincidentTopology : vtkGLSLModifierBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FBAC RID: 64428 RVA: 0x0015E2D7 File Offset: 0x0015C4D7
		static vtkGLSLModCoincidentTopology()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModCoincidentTopology.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModCoincidentTopology"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBAD RID: 64429 RVA: 0x0015E2FF File Offset: 0x0015C4FF
		public vtkGLSLModCoincidentTopology(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FBAE RID: 64430
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCoincidentTopology_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBAF RID: 64431 RVA: 0x0015E310 File Offset: 0x0015C510
		public new static vtkGLSLModCoincidentTopology New()
		{
			vtkGLSLModCoincidentTopology result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModCoincidentTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBB0 RID: 64432 RVA: 0x0015E364 File Offset: 0x0015C564
		public vtkGLSLModCoincidentTopology() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBB1 RID: 64433 RVA: 0x0015E3A8 File Offset: 0x0015C5A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FBB2 RID: 64434
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModCoincidentTopology_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBB3 RID: 64435 RVA: 0x0015E3B4 File Offset: 0x0015C5B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FBB4 RID: 64436
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGLSLModCoincidentTopology_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBB5 RID: 64437 RVA: 0x0015E3D4 File Offset: 0x0015C5D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FBB6 RID: 64438
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModCoincidentTopology_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBB7 RID: 64439 RVA: 0x0015E3F0 File Offset: 0x0015C5F0
		public override int IsA(string type)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FBB8 RID: 64440
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGLSLModCoincidentTopology_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBB9 RID: 64441 RVA: 0x0015E410 File Offset: 0x0015C610
		public new static int IsTypeOf(string type)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_IsTypeOf_04(type);
		}

		// Token: 0x0600FBBA RID: 64442
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModCoincidentTopology_IsUpToDate_05(HandleRef pThis, HandleRef arg0, HandleRef arg1, HandleRef arg2);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBBB RID: 64443 RVA: 0x0015E42C File Offset: 0x0015C62C
		public override bool IsUpToDate(vtkOpenGLRenderer arg0, vtkAbstractMapper arg1, vtkActor arg2)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_IsUpToDate_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis()) != 0;
		}

		// Token: 0x0600FBBC RID: 64444
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCoincidentTopology_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBBD RID: 64445 RVA: 0x0015E494 File Offset: 0x0015C694
		public new vtkGLSLModCoincidentTopology NewInstance()
		{
			vtkGLSLModCoincidentTopology result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGLSLModCoincidentTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FBBE RID: 64446
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGLSLModCoincidentTopology_ReplaceShaderValues_08(HandleRef pThis, HandleRef renderer, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string geometryShader, [MarshalAs(UnmanagedType.LPUTF8Str)] string fragmentShader, HandleRef mapper, HandleRef actor);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBBF RID: 64447 RVA: 0x0015E4F0 File Offset: 0x0015C6F0
		public override bool ReplaceShaderValues(vtkOpenGLRenderer renderer, string vertexShader, string geometryShader, string fragmentShader, vtkAbstractMapper mapper, vtkActor actor)
		{
			return vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_ReplaceShaderValues_08(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), vertexShader, geometryShader, fragmentShader, (mapper == null) ? default(HandleRef) : mapper.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis()) != 0;
		}

		// Token: 0x0600FBC0 RID: 64448
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModCoincidentTopology_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBC1 RID: 64449 RVA: 0x0015E560 File Offset: 0x0015C760
		public new static vtkGLSLModCoincidentTopology SafeDownCast(vtkObjectBase o)
		{
			vtkGLSLModCoincidentTopology vtkGLSLModCoincidentTopology = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModCoincidentTopology.vtkGLSLModCoincidentTopology_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModCoincidentTopology = (vtkGLSLModCoincidentTopology)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModCoincidentTopology.Register(null);
				}
			}
			return vtkGLSLModCoincidentTopology;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001250 RID: 4688
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModCoincidentTopology";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001251 RID: 4689
		public new static readonly string MRClassNameKey = "class vtkGLSLModCoincidentTopology";
	}
}
