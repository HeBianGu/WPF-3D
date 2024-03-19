using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPExtractHistogram2D
	/// </summary>
	/// <remarks>
	///    compute a 2D histogram between two columns
	///  of an input vtkTable in parallel.
	///
	///
	///  This class does exactly the same this as vtkExtractHistogram2D,
	///  but does it in a multi-process environment.  After each node
	///  computes their own local histograms, this class does an AllReduce
	///  that distributes the sum of all local histograms onto each node.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkExtractHistogram2D
	///
	/// @par Thanks:
	///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x02000477 RID: 1143
	public class vtkPExtractHistogram2D : vtkExtractHistogram2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D2E9 RID: 53993 RVA: 0x001257AD File Offset: 0x001239AD
		static vtkPExtractHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D2EA RID: 53994 RVA: 0x001257D5 File Offset: 0x001239D5
		public vtkPExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D2EB RID: 53995
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2EC RID: 53996 RVA: 0x001257E4 File Offset: 0x001239E4
		public new static vtkPExtractHistogram2D New()
		{
			vtkPExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractHistogram2D.vtkPExtractHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2ED RID: 53997 RVA: 0x00125838 File Offset: 0x00123A38
		public vtkPExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPExtractHistogram2D.vtkPExtractHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D2EE RID: 53998 RVA: 0x0012587C File Offset: 0x00123A7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D2EF RID: 53999
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractHistogram2D_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2F0 RID: 54000 RVA: 0x00125888 File Offset: 0x00123A88
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractHistogram2D.vtkPExtractHistogram2D_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600D2F1 RID: 54001
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractHistogram2D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2F2 RID: 54002 RVA: 0x001258F8 File Offset: 0x00123AF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPExtractHistogram2D.vtkPExtractHistogram2D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D2F3 RID: 54003
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractHistogram2D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2F4 RID: 54004 RVA: 0x00125918 File Offset: 0x00123B18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPExtractHistogram2D.vtkPExtractHistogram2D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D2F5 RID: 54005
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractHistogram2D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2F6 RID: 54006 RVA: 0x00125934 File Offset: 0x00123B34
		public override int IsA(string type)
		{
			return vtkPExtractHistogram2D.vtkPExtractHistogram2D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D2F7 RID: 54007
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractHistogram2D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2F8 RID: 54008 RVA: 0x00125954 File Offset: 0x00123B54
		public new static int IsTypeOf(string type)
		{
			return vtkPExtractHistogram2D.vtkPExtractHistogram2D_IsTypeOf_05(type);
		}

		// Token: 0x0600D2F9 RID: 54009
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractHistogram2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2FA RID: 54010 RVA: 0x00125970 File Offset: 0x00123B70
		public new vtkPExtractHistogram2D NewInstance()
		{
			vtkPExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractHistogram2D.vtkPExtractHistogram2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D2FB RID: 54011
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractHistogram2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2FC RID: 54012 RVA: 0x001259CC File Offset: 0x00123BCC
		public new static vtkPExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPExtractHistogram2D vtkPExtractHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractHistogram2D.vtkPExtractHistogram2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExtractHistogram2D = (vtkPExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExtractHistogram2D.Register(null);
				}
			}
			return vtkPExtractHistogram2D;
		}

		// Token: 0x0600D2FD RID: 54013
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPExtractHistogram2D_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2FE RID: 54014 RVA: 0x00125A4C File Offset: 0x00123C4C
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPExtractHistogram2D.vtkPExtractHistogram2D_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F96 RID: 3990
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F97 RID: 3991
		public new static readonly string MRClassNameKey = "class vtkPExtractHistogram2D";
	}
}
