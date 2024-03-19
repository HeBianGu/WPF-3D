using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParticleTracer
	/// </summary>
	/// <remarks>
	///    A Parallel Particle tracer for unsteady vector fields
	///
	/// vtkParticleTracer is a filter that integrates a vector field to advect particles
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParticleTracerBase has the details of the algorithms
	/// </seealso>
	// Token: 0x020004BD RID: 1213
	public class vtkParticleTracer : vtkParticleTracerBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DE61 RID: 56929 RVA: 0x001349DB File Offset: 0x00132BDB
		static vtkParticleTracer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParticleTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleTracer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE62 RID: 56930 RVA: 0x00134A03 File Offset: 0x00132C03
		public vtkParticleTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DE63 RID: 56931
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE64 RID: 56932 RVA: 0x00134A14 File Offset: 0x00132C14
		public new static vtkParticleTracer New()
		{
			vtkParticleTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracer.vtkParticleTracer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE65 RID: 56933 RVA: 0x00134A68 File Offset: 0x00132C68
		public vtkParticleTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParticleTracer.vtkParticleTracer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE66 RID: 56934 RVA: 0x00134AAC File Offset: 0x00132CAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DE67 RID: 56935
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleTracer_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE68 RID: 56936 RVA: 0x00134AB8 File Offset: 0x00132CB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParticleTracer.vtkParticleTracer_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DE69 RID: 56937
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleTracer_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE6A RID: 56938 RVA: 0x00134AD8 File Offset: 0x00132CD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParticleTracer.vtkParticleTracer_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DE6B RID: 56939
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracer_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE6C RID: 56940 RVA: 0x00134AF4 File Offset: 0x00132CF4
		public override int IsA(string type)
		{
			return vtkParticleTracer.vtkParticleTracer_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DE6D RID: 56941
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleTracer_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE6E RID: 56942 RVA: 0x00134B14 File Offset: 0x00132D14
		public new static int IsTypeOf(string type)
		{
			return vtkParticleTracer.vtkParticleTracer_IsTypeOf_04(type);
		}

		// Token: 0x0600DE6F RID: 56943
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracer_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE70 RID: 56944 RVA: 0x00134B30 File Offset: 0x00132D30
		public new vtkParticleTracer NewInstance()
		{
			vtkParticleTracer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracer.vtkParticleTracer_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DE71 RID: 56945
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleTracer_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE72 RID: 56946 RVA: 0x00134B8C File Offset: 0x00132D8C
		public new static vtkParticleTracer SafeDownCast(vtkObjectBase o)
		{
			vtkParticleTracer vtkParticleTracer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleTracer.vtkParticleTracer_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParticleTracer = (vtkParticleTracer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParticleTracer.Register(null);
				}
			}
			return vtkParticleTracer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001041 RID: 4161
		public new const string MRFullTypeName = "Kitware.VTK.vtkParticleTracer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001042 RID: 4162
		public new static readonly string MRClassNameKey = "class vtkParticleTracer";
	}
}
