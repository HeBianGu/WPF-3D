using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPBRLUTTexture
	/// </summary>
	/// <remarks>
	///    precompute BRDF look-up table texture used in physically based rendering
	///
	/// This texture is a 2D texture which precompute Fresnel response scale (red) and bias (green)
	/// based on roughness (x) and angle between light and normal (y).
	/// </remarks>
	// Token: 0x020005DE RID: 1502
	public class vtkPBRLUTTexture : vtkOpenGLTexture
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601062B RID: 67115 RVA: 0x0016D62B File Offset: 0x0016B82B
		static vtkPBRLUTTexture()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPBRLUTTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPBRLUTTexture"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601062C RID: 67116 RVA: 0x0016D653 File Offset: 0x0016B853
		public vtkPBRLUTTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601062D RID: 67117
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRLUTTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601062E RID: 67118 RVA: 0x0016D664 File Offset: 0x0016B864
		public new static vtkPBRLUTTexture New()
		{
			vtkPBRLUTTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRLUTTexture.vtkPBRLUTTexture_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRLUTTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601062F RID: 67119 RVA: 0x0016D6B8 File Offset: 0x0016B8B8
		public vtkPBRLUTTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPBRLUTTexture.vtkPBRLUTTexture_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010630 RID: 67120 RVA: 0x0016D6FC File Offset: 0x0016B8FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010631 RID: 67121
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRLUTTexture_GetLUTSamples_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of samples used during Monte-Carlo integration.
		/// Default is 512.
		/// </summary>
		// Token: 0x06010632 RID: 67122 RVA: 0x0016D708 File Offset: 0x0016B908
		public virtual uint GetLUTSamples()
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_GetLUTSamples_01(base.GetCppThis());
		}

		// Token: 0x06010633 RID: 67123
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPBRLUTTexture_GetLUTSize_02(HandleRef pThis);

		/// <summary>
		/// Set/Get size of texture.
		/// Default is 1024.
		/// </summary>
		// Token: 0x06010634 RID: 67124 RVA: 0x0016D728 File Offset: 0x0016B928
		public virtual uint GetLUTSize()
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_GetLUTSize_02(base.GetCppThis());
		}

		// Token: 0x06010635 RID: 67125
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRLUTTexture_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010636 RID: 67126 RVA: 0x0016D748 File Offset: 0x0016B948
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06010637 RID: 67127
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPBRLUTTexture_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010638 RID: 67128 RVA: 0x0016D768 File Offset: 0x0016B968
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06010639 RID: 67129
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRLUTTexture_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601063A RID: 67130 RVA: 0x0016D784 File Offset: 0x0016B984
		public override int IsA(string type)
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601063B RID: 67131
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPBRLUTTexture_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601063C RID: 67132 RVA: 0x0016D7A4 File Offset: 0x0016B9A4
		public new static int IsTypeOf(string type)
		{
			return vtkPBRLUTTexture.vtkPBRLUTTexture_IsTypeOf_06(type);
		}

		// Token: 0x0601063D RID: 67133
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRLUTTexture_Load_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x0601063E RID: 67134 RVA: 0x0016D7C0 File Offset: 0x0016B9C0
		public override void Load(vtkRenderer arg0)
		{
			vtkPBRLUTTexture.vtkPBRLUTTexture_Load_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601063F RID: 67135
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRLUTTexture_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010640 RID: 67136 RVA: 0x0016D7F0 File Offset: 0x0016B9F0
		public new vtkPBRLUTTexture NewInstance()
		{
			vtkPBRLUTTexture result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRLUTTexture.vtkPBRLUTTexture_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPBRLUTTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010641 RID: 67137
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRLUTTexture_Render_10(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Implement base class method.
		/// </summary>
		// Token: 0x06010642 RID: 67138 RVA: 0x0016D84C File Offset: 0x0016BA4C
		public override void Render(vtkRenderer ren)
		{
			vtkPBRLUTTexture.vtkPBRLUTTexture_Render_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06010643 RID: 67139
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPBRLUTTexture_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010644 RID: 67140 RVA: 0x0016D87C File Offset: 0x0016BA7C
		public new static vtkPBRLUTTexture SafeDownCast(vtkObjectBase o)
		{
			vtkPBRLUTTexture vtkPBRLUTTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPBRLUTTexture.vtkPBRLUTTexture_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPBRLUTTexture = (vtkPBRLUTTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPBRLUTTexture.Register(null);
				}
			}
			return vtkPBRLUTTexture;
		}

		// Token: 0x06010645 RID: 67141
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRLUTTexture_SetLUTSamples_12(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the number of samples used during Monte-Carlo integration.
		/// Default is 512.
		/// </summary>
		// Token: 0x06010646 RID: 67142 RVA: 0x0016D8FB File Offset: 0x0016BAFB
		public virtual void SetLUTSamples(uint _arg)
		{
			vtkPBRLUTTexture.vtkPBRLUTTexture_SetLUTSamples_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06010647 RID: 67143
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPBRLUTTexture_SetLUTSize_13(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get size of texture.
		/// Default is 1024.
		/// </summary>
		// Token: 0x06010648 RID: 67144 RVA: 0x0016D90B File Offset: 0x0016BB0B
		public virtual void SetLUTSize(uint _arg)
		{
			vtkPBRLUTTexture.vtkPBRLUTTexture_SetLUTSize_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001307 RID: 4871
		public new const string MRFullTypeName = "Kitware.VTK.vtkPBRLUTTexture";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001308 RID: 4872
		public new static readonly string MRClassNameKey = "class vtkPBRLUTTexture";
	}
}
