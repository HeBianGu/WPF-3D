using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractParticlesOverTime
	/// </summary>
	/// <remarks>
	///    Extract particles that goes through a given volumic data set.
	///
	/// vtkExtractParticlesOverTime extracts particles (points) from the first input that goes through
	/// the volume of the second input by iterating over time. Both inputs should be vtkDataSet objects.
	/// The first input should be temporal (i.e contains time steps), and the second one should be a
	/// volumic dataset (i.e contains 3D cells).
	///
	/// The output is a vtkDataSet that contains points which are subsets of the first input. The points
	/// move over time the same way the first input does.
	/// </remarks>
	// Token: 0x020006AE RID: 1710
	public class vtkExtractParticlesOverTime : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012470 RID: 74864 RVA: 0x00199B77 File Offset: 0x00197D77
		static vtkExtractParticlesOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractParticlesOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractParticlesOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012471 RID: 74865 RVA: 0x00199B9F File Offset: 0x00197D9F
		public vtkExtractParticlesOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012472 RID: 74866
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractParticlesOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06012473 RID: 74867 RVA: 0x00199BB0 File Offset: 0x00197DB0
		public new static vtkExtractParticlesOverTime New()
		{
			vtkExtractParticlesOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06012474 RID: 74868 RVA: 0x00199C04 File Offset: 0x00197E04
		public vtkExtractParticlesOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012475 RID: 74869 RVA: 0x00199C48 File Offset: 0x00197E48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012476 RID: 74870
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractParticlesOverTime_GetIdChannelArray_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of a scalar array which will be used to fetch
		/// the index of each point. This is necessary only if the particles
		/// change position (Id order) on each time step. The Id can be used
		/// to identify particles at each step and hence track them properly.
		/// If this array is nullptr, the global point ids are used.  If an Id
		/// array cannot otherwise be found, the point index is used as the ID.
		/// </summary>
		// Token: 0x06012477 RID: 74871 RVA: 0x00199C54 File Offset: 0x00197E54
		public virtual string GetIdChannelArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_GetIdChannelArray_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06012478 RID: 74872
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06012479 RID: 74873 RVA: 0x00199C90 File Offset: 0x00197E90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601247A RID: 74874
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x0601247B RID: 74875 RVA: 0x00199CB0 File Offset: 0x00197EB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601247C RID: 74876
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractParticlesOverTime_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x0601247D RID: 74877 RVA: 0x00199CCC File Offset: 0x00197ECC
		public override int IsA(string type)
		{
			return vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601247E RID: 74878
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractParticlesOverTime_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x0601247F RID: 74879 RVA: 0x00199CEC File Offset: 0x00197EEC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_IsTypeOf_05(type);
		}

		// Token: 0x06012480 RID: 74880
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractParticlesOverTime_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06012481 RID: 74881 RVA: 0x00199D08 File Offset: 0x00197F08
		public new vtkExtractParticlesOverTime NewInstance()
		{
			vtkExtractParticlesOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012482 RID: 74882
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractParticlesOverTime_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Type-Macro
		/// </summary>
		// Token: 0x06012483 RID: 74883 RVA: 0x00199D64 File Offset: 0x00197F64
		public new static vtkExtractParticlesOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractParticlesOverTime vtkExtractParticlesOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractParticlesOverTime = (vtkExtractParticlesOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractParticlesOverTime.Register(null);
				}
			}
			return vtkExtractParticlesOverTime;
		}

		// Token: 0x06012484 RID: 74884
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractParticlesOverTime_SetIdChannelArray_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify the name of a scalar array which will be used to fetch
		/// the index of each point. This is necessary only if the particles
		/// change position (Id order) on each time step. The Id can be used
		/// to identify particles at each step and hence track them properly.
		/// If this array is nullptr, the global point ids are used.  If an Id
		/// array cannot otherwise be found, the point index is used as the ID.
		/// </summary>
		// Token: 0x06012485 RID: 74885 RVA: 0x00199DE3 File Offset: 0x00197FE3
		public virtual void SetIdChannelArray(string arg)
		{
			vtkExtractParticlesOverTime.vtkExtractParticlesOverTime_SetIdChannelArray_09(base.GetCppThis(), arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150A RID: 5386
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractParticlesOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400150B RID: 5387
		public new static readonly string MRClassNameKey = "class vtkExtractParticlesOverTime";
	}
}
