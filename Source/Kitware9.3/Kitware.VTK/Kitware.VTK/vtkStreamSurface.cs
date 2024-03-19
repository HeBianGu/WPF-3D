using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreamSurface
	/// </summary>
	/// <remarks>
	///    Advect a stream surface in a vector field
	///
	/// vtkStreamSurface is a surface streamer that generates a surface using the vectors in the input.
	/// Depending on the UseIterativeSeeding parameter, the simple or iterative version is called.
	/// The iterative version produces better surfaces, but takes longer.
	///
	/// @par Thanks:
	/// Developed by Roxana Bujack and Karen Tsai at Los Alamos National Laboratory under LDRD 20190143ER
	/// </remarks>
	// Token: 0x020004C5 RID: 1221
	public class vtkStreamSurface : vtkStreamTracer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DF11 RID: 57105 RVA: 0x0013575D File Offset: 0x0013395D
		static vtkStreamSurface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamSurface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF12 RID: 57106 RVA: 0x00135785 File Offset: 0x00133985
		public vtkStreamSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DF13 RID: 57107
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF14 RID: 57108 RVA: 0x00135794 File Offset: 0x00133994
		public new static vtkStreamSurface New()
		{
			vtkStreamSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamSurface.vtkStreamSurface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF15 RID: 57109 RVA: 0x001357E8 File Offset: 0x001339E8
		public vtkStreamSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreamSurface.vtkStreamSurface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF16 RID: 57110 RVA: 0x0013582C File Offset: 0x00133A2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DF17 RID: 57111
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamSurface_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF18 RID: 57112 RVA: 0x00135838 File Offset: 0x00133A38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreamSurface.vtkStreamSurface_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DF19 RID: 57113
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreamSurface_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF1A RID: 57114 RVA: 0x00135858 File Offset: 0x00133A58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreamSurface.vtkStreamSurface_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DF1B RID: 57115
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStreamSurface_GetUseIterativeSeeding_03(HandleRef pThis);

		/// <summary>
		/// Specify/determine if the simple (fast) or iterative (correct) version is called.
		/// </summary>
		// Token: 0x0600DF1C RID: 57116 RVA: 0x00135874 File Offset: 0x00133A74
		public virtual bool GetUseIterativeSeeding()
		{
			return vtkStreamSurface.vtkStreamSurface_GetUseIterativeSeeding_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DF1D RID: 57117
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamSurface_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF1E RID: 57118 RVA: 0x0013589C File Offset: 0x00133A9C
		public override int IsA(string type)
		{
			return vtkStreamSurface.vtkStreamSurface_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600DF1F RID: 57119
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreamSurface_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF20 RID: 57120 RVA: 0x001358BC File Offset: 0x00133ABC
		public new static int IsTypeOf(string type)
		{
			return vtkStreamSurface.vtkStreamSurface_IsTypeOf_05(type);
		}

		// Token: 0x0600DF21 RID: 57121
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamSurface_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF22 RID: 57122 RVA: 0x001358D8 File Offset: 0x00133AD8
		public new vtkStreamSurface NewInstance()
		{
			vtkStreamSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamSurface.vtkStreamSurface_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DF23 RID: 57123
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreamSurface_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF24 RID: 57124 RVA: 0x00135934 File Offset: 0x00133B34
		public new static vtkStreamSurface SafeDownCast(vtkObjectBase o)
		{
			vtkStreamSurface vtkStreamSurface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreamSurface.vtkStreamSurface_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamSurface = (vtkStreamSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamSurface.Register(null);
				}
			}
			return vtkStreamSurface;
		}

		// Token: 0x0600DF25 RID: 57125
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamSurface_SetUseIterativeSeeding_09(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/determine if the simple (fast) or iterative (correct) version is called.
		/// </summary>
		// Token: 0x0600DF26 RID: 57126 RVA: 0x001359B3 File Offset: 0x00133BB3
		public virtual void SetUseIterativeSeeding(bool _arg)
		{
			vtkStreamSurface.vtkStreamSurface_SetUseIterativeSeeding_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DF27 RID: 57127
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamSurface_UseIterativeSeedingOff_10(HandleRef pThis);

		/// <summary>
		/// Specify/determine if the simple (fast) or iterative (correct) version is called.
		/// </summary>
		// Token: 0x0600DF28 RID: 57128 RVA: 0x001359CB File Offset: 0x00133BCB
		public virtual void UseIterativeSeedingOff()
		{
			vtkStreamSurface.vtkStreamSurface_UseIterativeSeedingOff_10(base.GetCppThis());
		}

		// Token: 0x0600DF29 RID: 57129
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStreamSurface_UseIterativeSeedingOn_11(HandleRef pThis);

		/// <summary>
		/// Specify/determine if the simple (fast) or iterative (correct) version is called.
		/// </summary>
		// Token: 0x0600DF2A RID: 57130 RVA: 0x001359DA File Offset: 0x00133BDA
		public virtual void UseIterativeSeedingOn()
		{
			vtkStreamSurface.vtkStreamSurface_UseIterativeSeedingOn_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400105F RID: 4191
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamSurface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001060 RID: 4192
		public new static readonly string MRClassNameKey = "class vtkStreamSurface";
	}
}
